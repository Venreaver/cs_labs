using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class Matrix
    {
        // 1. Данные.
        // Структура для хранения данных (элементов матрицы) может быть реализована в виде прямоугольного массива
        double[,] data;

        // 2. Конструкторы
        public Matrix(int nRows, int nCols)
        {
            data = new double[nRows, nCols];
        }
        public Matrix(double[,] initData)
        {
            data = new double[initData.GetLength(0), initData.GetLength(1)];
            Array.Copy(initData, data, initData.Length);
        }

        // 3. Свойства.
        // 3.1. Cвойство-индексатор:
        public double this[int i, int j]
        {
            set { data[i, j] = value; }
            get { return data[i, j]; }
        }

        // 3.2. Размер матрицы доступен только для чтения через свойства:
        public int Rows
        {
            get { return data.GetLength(0); } 
        }
        public int Columns
        {
            get { return data.GetLength(1); }
        }

        // 3.3. Размер квадратной матрицы
        public int? Size
        {
            get
            {
                if (IsSquared)
                {
                    return Rows;
                }
                return null;
            }
        }

        // 3.4. Несколько булевых свойств:
        // 3.4.1. Является ли матрица квадратной
        public bool IsSquared
        {
            get { return data.GetLength(0) == data.GetLength(1); }
        }
        // 3.4.2. Является ли матрица нулевой
        public bool IsEmpty
        {
            get
            {
                foreach (var item in data)
                {
                    if (item != 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        // 3.4.3. Является ли матрица единичной
        public bool IsUnity
        {
            get
            {
                if (IsSquared)
                {
                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        if (data[i,i] != 1)
                        {
                            return false;
                        }
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            if ((i != j) && (data[i, j] != 0))
                            {
                                return false;
                            }
                        }
                    }
                    return true;
                }
                return false;
            }
        }
        // 3.4.4. Является ли матрица диагональной
        public bool IsDiagonal
        {
            get
            {
                if (IsSquared)
                {
                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            if ((i != j) && (data[i, j] != 0))
                            {
                                return false;
                            }
                        }
                    }
                    return true;
                }
                return false;
            }
        }
        // 3.4.5. Является ли матрица симметричной
        public bool IsSymmetric
        {
            get
            {
                if (IsSquared)
                {
                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            if (data[i, j] != data[j, i])
                            {
                                return false;
                            }
                        }
                    }
                    return true;
                }
                return false;
            }
        }
        // 4. Операторы.
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if ((m1.Rows == m2.Rows) && (m1.Columns == m2.Columns))
            {
                Matrix res = new Matrix(m1.Rows, m1.Columns);
                for (int i = 0; i < res.Rows; i++)
                {
                    for (int j = 0; j < res.Columns; j++)
                    {
                        res[i, j] = m1[i, j] + m2[i, j];
                    }
                }
                return res;
            }
            else
            {
                throw new MatrixException(1, "Ranges of matrices");
            }
        }
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            if ((m1.Rows == m2.Rows) && (m1.Columns == m2.Columns))
            {
                Matrix res = new Matrix(m1.Rows, m1.Columns);
                for (int i = 0; i < res.Rows; i++)
                {
                    for (int j = 0; j < res.Columns; j++)
                    {
                        res[i, j] = m1[i, j] - m2[i, j];
                    }
                }
                return res;
            }
            else
            {
                throw new MatrixException(2, "Ranges of matrices");
            }
        }
        public static Matrix operator *(Matrix m1, double d)
        {
            Matrix res = new Matrix(m1.Rows, m1.Columns);
            for (int i = 0; i < res.Rows; i++)
            {
                for (int j = 0; j < res.Columns; j++)
                {
                    res[i, j] = m1[i, j] * d;
                }
            }
            return res;
        }
        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1.Columns == m2.Rows)
            {
                Matrix res = new Matrix(m1.Rows, m2.Columns);
                for (int i = 0; i < res.Rows; i++)
                {
                    for (int j = 0; j < res.Columns; j++)
                    {
                        
                        for (int k = 0; k < m1.Rows; k++)
                        {
                            res[i, j] += m1[i, k] * m1[k, j];
                        }
                    }
                }
                return res;
            }
            else
            {
                throw new MatrixException(3, "Ranges of matrices");
            }

        }

        public static explicit operator Matrix(double[,] arr)
        {
            return new Matrix(arr);
        }
        // 5. Методы
        // 5.1. Транспонирование
        public Matrix Transpose()
        {
            Matrix res = new Matrix(Columns, Rows);
            for (int i = 0; i < Columns; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    res[i, j] = this[j, i];
                }
            }
            return res;
        }
        // 5.2. След матрицы
        public double Trace()
        {
            if (IsSquared)
            {
                double res = 0;
                for (int i = 0; i < Rows; i++)
                {
                    res += this[i, i];
                }
                return res;
            }
            throw new MatrixException(0, "notSquared");
        }
        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    res += " " + this[i, j];
                }
                res += ",";
            }
            return res.TrimStart().TrimEnd(',');
        }
        // 6. Статические методы
        // 6.1. Статические методы для порождения единичной и нулевой матрицы определенного размера
        public static Matrix GetUnity(int size)
        {
            Matrix res = new Matrix(size, size);
            for (int i = 0; i < res.Size; i++)
            {
                res[i, i] = 1;
            }
            return res;
        }
        public static Matrix GetEmpty(int size)
        {
            return new Matrix(size, size);
        }
        // 6.2. Статические методы для создания матрицы по строчке в определенном формате
        public static Matrix Parse(string s)
        {
            var strings = s.Split(',').Select(str => str.Trim().Split(' ')).ToArray();
            int n = strings[0].Length;
            var flag = !strings.Any(t => t.Length != n);
            if (flag)
            {
                Matrix res = new Matrix(strings.Length, strings[0].Length);
                for (int i = 0; i < res.Rows; i++)
                {
                    for (int j = 0; j < res.Columns; j++)
                    {
                        res[i, j] = int.Parse(strings[i][j]);
                    }
                }
                return res;
            }
            throw new FormatException("Неверный формат строки!");
        }
        public static bool TryParse(string s, out Matrix m)
        {
            try
            {
                m = Parse(s);
                return true;
            }
            catch (Exception)
            {
                m = null;
                return false;
            }

        }
    }
}
