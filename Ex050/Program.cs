/*Задача 50.
 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента в массиве нет */


using System;

class MainClass {
  public static void Main (string[] args) {
    int[,] arr = {
        {1, 4, 7, 2},
        {5, 9, 2, 3},
        {8, 4, 2, 4},
    };

    int x, y;

    Console.WriteLine("Enter the x and y position of the element you want to access:");

    x = int.Parse(Console.ReadLine());
    y = int.Parse(Console.ReadLine());

    try {
        Console.WriteLine("The element at position ({0}, {1}) is {2}", x, y, arr[x, y]);
    } catch(IndexOutOfRangeException) {
        Console.WriteLine("There is no element at position ({0}, {1}) in the array", x, y);
    }
  }
}