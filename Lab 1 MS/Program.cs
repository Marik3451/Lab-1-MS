using System;

namespace RandomSequenceGenerator
{
    class Program
    {
        static (int[], double) RealizationOfRandom(double probability, int m)
        {
            // Ініціалізуємо порожній масив для збереження реалізацій
            int[] realizationsSeq = new int[m];
            int happened = 0;
            int notHappened = 0;
            Random random = new Random();

            // Генеруємо послідовність
            for (int i = 0; i < m; i++)
            {
                // Генеруємо випадкове число від 0 до 1
                double randomNumber = random.NextDouble();

                if (randomNumber <= probability)
                {
                    realizationsSeq[i] = 1;
                    happened++;
                }
                else
                {
                    realizationsSeq[i] = 0;
                    notHappened++;
                }
            }

            double probabilityOfHappening = (double)happened / m;
            return (realizationsSeq, probabilityOfHappening);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Завдання №1. Варіант - 10");
            Console.WriteLine();

            Console.Write("Введіть значення M - кількість реалізацій: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введіть значення P - ймовірність [0, 1]: ");
            double probability = double.Parse(Console.ReadLine());

            var task1 = RealizationOfRandom(probability, m);
            int[] seq1 = task1.Item1;

            Console.WriteLine($"Ймовірність: {task1.Item2}");
            Console.WriteLine("Послідовність реалізацій:");
            foreach (int realization in seq1)
            {
                Console.WriteLine(realization);
            }
        }
    }
}
