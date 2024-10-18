using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga3
{
    internal class Program
    {
        static void homerseklet()
        {
            double[] temperatures = new double[7];

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Kérlek, add meg a(z) {i + 1}. nap hőmérsékletét (°C): ");
                temperatures[i] = Convert.ToDouble(Console.ReadLine());
            }

            double sum = 0;
            double maxTemperature = temperatures[0];
            double minTemperature = temperatures[0];
            bool hasFrostDay = false;

            for (int i = 0; i < 7; i++)
            {
                sum += temperatures[i];

                if (temperatures[i] > maxTemperature)
                {
                    maxTemperature = temperatures[i];
                }

                if (temperatures[i] < minTemperature)
                {
                    minTemperature = temperatures[i];
                }

                if (temperatures[i] < 0)
                {
                    hasFrostDay = true;
                }
            }

            double averageTemperature = sum / 7;

            Console.WriteLine($"\nA hét átlaghőmérséklete: {averageTemperature:F2} °C");
            Console.WriteLine($"A legmelegebb nap hőmérséklete: {maxTemperature} °C");
            Console.WriteLine($"A leghidegebb nap hőmérséklete: {minTemperature} °C");

            if (hasFrostDay)
            {
                Console.WriteLine("Fagypont alatti nap is volt!");
            }
        }
        static void Main(string[] args)
        {
            homerseklet();
        }
    }
}
