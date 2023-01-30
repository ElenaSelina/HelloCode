/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

using System;

namespace Task58
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = { { 2, 4 }, { 3, 2 } };
            int[,] arr2 = { { 3, 4 }, { 3, 3 } };
            int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < arr2.GetLength(0); k++)
                    {
                        sum += arr1[i, k] * arr2[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            for (int i = 0;
