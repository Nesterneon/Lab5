using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiveNN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество N строк и столбцов массива");
            int N = Int32.Parse(Console.ReadLine());
            int[,] array = new int [N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = 1 - (i + j) % 2;
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();

        }
    }
}
