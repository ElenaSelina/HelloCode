/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

class Program
{
    static void Main(string[] args)
    {
        int[][] arr = new int[3][];

        Console.WriteLine("result 1: \n");
        {
            int[,] a = new int[,] { { 2, 3 }, { 4, 2 } };
            int[,] b = new int[,] { { 3, 3 }, { 4, 3 } };

            int[,] result = Program.MultiplyMatrix(a, b);
            Program.PrintMatrix(result);
        }

        Console.WriteLine("\nresult 2: \n");
        {
            int[,] a = new int[,] { { 2, -3, 4 }, { 1, 0, -1 } };
            int[,] b = new int[,] { { 5, -3 }, { -1, 0 }, { 6, 7 } };

            int[,] result = Program.MultiplyMatrix(a, b);
            Program.PrintMatrix(result);
        }
    }

    public static int[,] MultiplyMatrix(int[,] m1, int[,] m2) {
        int sumMaxIndex = m1.GetLength(0);

        if (m2.GetLength(1) != sumMaxIndex) {
            throw new Exception("matrices are not consistent");
        }

        int resultRawCount = m1.GetLength(1);
        int resultColumnCount = m2.GetLength(0);

        int[,] result = new int[resultRawCount, resultColumnCount];
        for (int i = 0; i < resultRawCount; i++)
        {
            for (int j = 0; j < resultColumnCount; j++)
            {
                int resultItem = 0;

                for (int r = 0; r < sumMaxIndex; r++)
                {
                    resultItem = resultItem + m1[r, i] * m2[j, r];
                }

                result[i, j] = resultItem;
            }
        }

        return result;
    }

    public static void PrintMatrix(int[,] matrix) {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j] + "\t");
            }

            Console.WriteLine();
        }
    }
}
