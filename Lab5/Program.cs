using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение 7 элементов массива");
            int [] a =new int [7];
            float avarage = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Введите значение {0}-й элемент",i+1);
                a[i] = Int32.Parse(Console.ReadLine());
            }
            if (a.Length > 0) ;
            {
                float sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                avarage = sum / a.Length;
            }
            Console.WriteLine("среднее арифметическое элементов = {0}",avarage);
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
