using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Task2
{
    class Program
    {
        /* Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных или количество отрицательных.
         Последовательность потенциально не ограничена, окончанием последовательности служит число 0. */
        static void Main(string[] args)
        {
            int i;
            int SumPlus = 0;
            int SumMinus = 0;
            do
            {
                i = Convert.ToInt32(Console.ReadLine());
                if (i > 0)
                    SumPlus++;
                if (i < 0)
                    SumMinus++;

            } while (i != 0);

            if (SumPlus > SumMinus)
            {
                Console.WriteLine("Количество положительных целых чисел больше");
            }
            else
            {
                if (SumMinus > SumPlus)
                {
                    Console.WriteLine("Количество отрицательных целых чисел больше");
                }
                else
                {
                    if ((SumMinus == 0) && (SumPlus == 0))
                    {
                        Console.WriteLine("Последовательность не задана");
                    }
                    else
                    {
                        Console.WriteLine("Количество положительных и отрицательных целых чисел равно");
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
