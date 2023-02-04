/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

class Program
{
    static void Main(string[] args)
    {
        int[][] arr = new int[3][];

        arr[0] = new int[] { 1, 4, 7, 2 };
        arr[1] = new int[] { 5, 9, 2, 3 };
        arr[2] = new int[] { 8, 4, 2, 4 };

        int rows = arr.GetLength(0);
        int columns = arr[0].GetLength(0);

        for (int i = 0; i < rows; i++)
        {
            Array.Sort(arr[i], new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
        }

        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine("number list: " + string.Join(",", arr[i]));
        }
    }
}
