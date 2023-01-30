/* Задача 38.  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 */

class Program {
    public static void Main (string[] args) {
        int[] numbers = Program.generateNumArray(10);

        int max = numbers.Max();
        int min = numbers.Min();
        int diff = max - min;

        Program.printArr(numbers);
        Console.WriteLine("max: " + min);
        Console.WriteLine("min: " + max);
        Console.WriteLine("max - min: " + diff);
    }

    public static int [] generateNumArray(int size) {
        int Min = 0;
        int Max = 100;

        int[] numbers = new int[size];

        Random randNum = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = randNum.Next(Min, Max);
        }

        return numbers;
    }

    public static void printArr(int[] arr) {
       Console.WriteLine("number list: " + string.Join(",", arr));
    }
}