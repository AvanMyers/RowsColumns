using System;

namespace RowsColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int multiplication = 1;
            int minRandomNumber = 1;
            int maxRandomNumber = 9;
            int lineNumber = 2;
            int colimnNumber = 1;

            int[,] array = new int[3, 3];

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minRandomNumber, maxRandomNumber + 1);
                    Console.Write(array[i, j]);
                }

                Console.WriteLine();
            }

            for (int i = 0; i < array.GetLength(1); i++)
                sum += array[lineNumber - 1, i];

            for (int i = 0; i < array.GetLength(0); i++)
                multiplication *= array[i, colimnNumber - 1];

            Console.WriteLine($"Сумма {lineNumber} строки {sum}");
            Console.WriteLine($"Произведение {colimnNumber} столбца {multiplication}");
            Console.ReadKey();
        }
    }
}
