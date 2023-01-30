/* Задача 36.  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0  */

class Program {
    public static void Main (string[] args) {
        int[] numbers = Program.generateNumArray(10);
        Program.printArr(numbers);
        int sum = numbers.Where((x,i) => i % 2 != 0).Sum();
        Console.WriteLine(sum);
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