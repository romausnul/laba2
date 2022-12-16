using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ConsoleApp
{
    class Program
    {
        public static double GetParallelResistance(double r1, double r2)
        {
            if ((r1 <= 0) || (r2 <= 0))
            {
                Console.WriteLine("Введены неверные значения сопротивлений.");
                Environment.Exit(1);
            }
            return r1 * r2 / (r1 + r2);
        }

        static void Main()
        {
            double r1 = 0, r2 = 0;
            try
            {
                Console.WriteLine("Введите значение первого сопротивления: ");
                r1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите пж второго сопротивления: ");
                r2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный ввод, ты что совсем уже.");
                Environment.Exit(1);
            }

            Console.WriteLine("Сопротивление при параллельном соединении: {0}", GetParallelResistance(r1, r2));
        }
    }
}