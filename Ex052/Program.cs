/* Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

class MainClass {
  public static void Main (string[] args) {
    int[,] array = {
        {1, 4, 7, 2},
        {5, 9, 2, 3},
        {8, 4, 2, 4},
    };

    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for(int i = 0; i < columns; i++)
    {
        int sum = 0;
        for(int j = 0; j < rows; j++)
        {
            sum += array[j,i];
        }
        double average = (double)sum / rows;
        Console.Write("column " + (i + 1) + " " + average + "\n");
    }

  }
}