using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class MatrixException : Exception
    {
        string SomeAdditionStringInfo;
        public MatrixException(int i, string msg) : base(msg)
        {
            switch (i)
            {
                case 1:
                    SomeAdditionStringInfo = "Матрицы имеют несовместимую размерность для сложения!";
                    break;
                case 2:
                    SomeAdditionStringInfo = "Матрицы имеют несовместимую размерность для вычитания!";
                    break;
                case 3:
                    SomeAdditionStringInfo = "Матрицы имеют несовместимую размерность!\nМатрицы не являются согласованными для произведения матриц!";
                    break;
                default:
                    SomeAdditionStringInfo = "Матрица не квадратная.\nНельзя узнать след матрицы!";
                    break;
            }
        }

        public override string ToString()
        {
            return SomeAdditionStringInfo;
        }
    }
}
