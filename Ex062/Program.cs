/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 4];
            int value = 1;
            int minRow = 0, maxRow = arr.GetLength(0) - 1;
            int minCol = 0, maxCol = arr.GetLength(1) - 1;

            while (value <= arr.Length)
            {
                for (int i = minRow; i <= maxRow; i++)
                {
                    arr[i, minCol] = value++;
                }
                minCol++;

                for (int i = minCol; i <= maxCol; i++)
                {
                    arr[maxRow, i] = value++;
                }
                maxRow--;

                for (int i = maxRow; i >= minRow; i--)
                {
                    arr[i, maxCol] = value++;
                }
                maxCol--;

                for (int i = maxCol; i >= minCol; i--)
                {
                    arr[minRow, i] = value++;
                }
                minRow++;
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j].ToString().PadLeft(2, '0') + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

