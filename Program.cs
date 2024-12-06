using System;

namespace RowsColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int summ = 0;
            int multiplication = 1;
            int minRandom = 1;
            int maxRandom = 10;

            int[,] array = new int[3, 3];

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    number = random.Next(minRandom, maxRandom);
                    array[i, j] = number;
                    Console.Write(array[i, j]);

                    if (i == 1)
                        summ += array[i, j];

                    if (j == 0)
                        multiplication *= array[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Сумма второй строки {summ}");
            Console.WriteLine($"Произведение первого столбца {multiplication}");
            Console.ReadKey();
        }
    }
}
