using System;
using static ConsoleApp1.moduleAttribute;
namespace ConsoleApp1
{
    class Program
    {//Функция ввода размера вектора
       
        static void Main(string[] args)
        {
            
            int n = size_v();

            float[] x = new float[n];
            write_v(x,"x");
            sort_v_Shell(x);

            float[] y = new float[n];
            write_v(y,"y");
            sort_v_Shell(y);

            float[] z = new float[n];
            write_v(z,"z");
            sort_v_Shell(z);
            //задания матрицы
            float[,] A = new float[3, x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                A[0,i] = x[i];
            }
            for (int i = 0; i < y.Length; i++)
            {
                A[1,i] = y[i];

            }
            for (int i = 0; i < z.Length; i++)
            {
                A[2,i] = z[i];

            }
            //вывод матрицы
            string s = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    s += string.Format(" {0:f}    ", A[i, j]);
                }
                s += "\n";
            }
            Console.WriteLine(s);
        }
    }
}
