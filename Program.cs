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
            int amountLine = 2;
            int multiplicationColumn = 1;

            int[,] array = new int[3, 3];

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    number = random.Next(minRandom, maxRandom);
                    array[i, j] = number;
                    Console.Write(array[i, j]);
                }

                Console.WriteLine();
            }

            for (int i = 0; i < array.GetLength(1); i++)
                summ += array[amountLine - 1, i];

            for (int i = 0; i < array.GetLength(0); i++)
                multiplication *= array[i, multiplicationColumn - 1];

            Console.WriteLine($"Сумма второй строки {summ}");
            Console.WriteLine($"Произведение первого столбца {multiplication}");
            Console.ReadKey();
        }
    }
}
