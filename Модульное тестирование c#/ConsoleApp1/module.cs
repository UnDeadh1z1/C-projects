using System;

namespace ConsoleApp1
{
    internal class moduleAttribute : Attribute
    {
       public static int size_v()
        {
            int x = -1;
            while (x > 7 || x < 2)
            {
                try
                {

                    Console.WriteLine("ВВЕДИТЕ РАЗМЕР ВЕКТОРОВ");
                    x = int.Parse(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.WriteLine("ВВЕДЕНО НЕКОРРЕКТНОЕ ЗНАЧЕНИЕ");
                }
            }
            return x;
        }
        //Функция ввода значения вектора 
        public static void write_v(float[] v, string s)
        {
            int i = 0;
            while (i < v.Length)
            {
                try
                {
                    Console.WriteLine(string.Format("ВВЕДИТЕ ЗНАЧЕНИЕ {0:d} ВЕКТОРА {1:s}", i + 1, s));
                    v[i] = float.Parse(Console.ReadLine());
                    while( v[i]  > 100.0 || v[i] < -100.0){
                        Console.WriteLine(string.Format("ВВЕДИТЕ ЗНАЧЕНИЕ {0:d} ВЕКТОРА {1:s}", i + 1, s));
                        v[i] = float.Parse(Console.ReadLine());
                    }
                    i++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ВВЕДЕНО НЕКОРРЕКТНОЕ ЗНАЧЕНИЕ");
                }
            }
        }
        //функция сортировки вектора методом Шелла
        public static void sort_v_Shell(float[] v)
        {
            int d = v.Length;
            d = d / 2;
            while (d > 0)
            {
                for (int i = 0; i < v.Length - d; i++)
                {
                    int j = i;
                    while (j >= 0 && v[j] > v[j + d])
                    {
                        float count = v[j];
                        v[j] = v[j + d];
                        v[j + d] = count;
                        j--;
                    }
                }
                d = d / 2;
            }
        }
    }
}
