using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Matrix> dic = new Dictionary<string, Matrix>();
            Console.WriteLine(
@"Работа с матрицами через строку ввода:
-------------------------------
 Формат для ввода матрицы:               m1 = 1 1 1, 2 2 2, 3 3 3
 Формат для сложения матриц:             m3 = m1 + m2
 Формат для вычитания матриц:            m3 = m1 - m2
 Формат для умножения матриц:            m3 = m1 * m2
 Формат для умножения матрицы на double: m3 = m1 * 3,14
 Формат для транспонирования матрицы:    m3 = (transp) m2
 Формат для вывода матрицы на экран:     m3
 0 - Выход
-------------------------------");
            while (true)
            {
                Console.Write("> ");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        string str = Console.ReadLine();
                        str = str.Replace(" = ", "=");
                        try
                        {
                            if (str.Contains('='))
                            {
                                Matrix newOne = null;
                                string strMatrixName = str.Split('=')[0].Trim();
                                string strMsg = str.Split('=')[1].Trim();
                                char[] interStr = str.Intersect("+-*").ToArray();
                                if (interStr.Length == 1)
                                {
                                    Matrix matr1;
                                    Matrix matr2;
                                    bool first;
                                    bool second;
                                    switch (interStr[0])
                                    {
                                        case '*':
                                            double d;
                                            bool dbl = double.TryParse(strMsg.Split(interStr[0])[1].Trim(), out d);
                                            if (dbl)
                                            {
                                                first = dic.TryGetValue(strMsg.Split(interStr[0])[0].Trim(), out matr1);
                                                if (first)
                                                {
                                                    newOne = matr1 * d;
                                                }
                                            }
                                            else
                                            {
                                                first = dic.TryGetValue(strMsg.Split(interStr[0])[0].Trim(), out matr1);
                                                second = dic.TryGetValue(strMsg.Split(interStr[0])[1].Trim(), out matr2);
                                                if (first && second)
                                                {
                                                    newOne = matr1 * matr2;
                                                }
                                            }
                                            break;
                                        default:
                                            first = dic.TryGetValue(strMsg.Split(interStr[0])[0].Trim(), out matr1);
                                            second = dic.TryGetValue(strMsg.Split(interStr[0])[1].Trim(), out matr2);
                                            if (first && second)
                                            {
                                                if (interStr[0] == '+')
                                                {
                                                    newOne = matr1 + matr2;
                                                }
                                                else
                                                {
                                                    newOne = matr1 - matr2;
                                                }
                                            }
                                            break;
                                    }
                                }
                                else if (str.Contains("(transp)"))
                                {
                                    strMsg = strMsg.Replace("(transp)", "").Trim();
                                    bool flag = dic.TryGetValue(strMsg, out newOne);
                                    if (flag)
                                    {
                                        newOne = newOne.Transpose();
                                    }
                                }
                                else
                                {
                                    bool flag = Matrix.TryParse(strMsg, out newOne);
                                }
                                if (newOne != null)
                                {
                                    if (dic.ContainsKey(strMatrixName))
                                    {
                                        dic[strMatrixName] = newOne;
                                    }
                                    else
                                    {
                                        dic.Add(strMatrixName, newOne);
                                    }
                                    Console.WriteLine($"matrix created ({newOne.Rows} x {newOne.Columns})");
                                }
                                else
                                {
                                    Console.WriteLine($"Операнд(-ы) операции не существует(-ют)!");
                                }
                                Console.WriteLine();
                            }
                            else
                            {
                                MatrixShow(dic, str);
                            }
                        }
                        catch (MatrixException ex)
                        {
                            Console.WriteLine(ex);
                        }
                        break;
                }
            }
        }

        public static void MatrixShow(Dictionary<string, Matrix> dic, string str)
        {
            Matrix m;
            bool flag = dic.TryGetValue(str.Replace(" ", ""), out m);
            if (flag)
            {
                for (int i = 0; i < m.Rows; i++)
                {
                    for (int j = 0; j < m.Columns; j++)
                    {
                        Console.Write(m[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"Матрицы \"{str}\" не существует\nИли строка \"{str}\" не соовтествует обратабываемым форматам строк");
            }
            Console.WriteLine();
        }
    }
}