/* Задача 60.
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Например, задан массив размером 2 x 2 x 2.
Результат:
66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1) */

class Program
{
    static void Main(string[] args)
    {
        int[,,] result = new int[2, 2, 2];
        int[] numbers = new int[] { 66, 27, 25, 90, 34, 26, 41, 55 };
        int index = 0;

        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                for (int k = 0; k < result.GetLength(2); k++)
                {
                    result[i, j, k] = numbers[index++];
                }
            }
        }

        Program.PrintResult(result);
    }

    public static void PrintResult(int [,,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(2); k++)
                {
                    Console.Write(arr[i, j, k] + "(" + i + "," + j + "," + k + ")" + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

