/* Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */


class Program {
    public static void Main (string[] args) {
        int count = 0;

        Console.WriteLine("Enter the number of numbers you want to input:");

        int m = int.Parse(Console.ReadLine());

        for(int i = 1; i <= m; i++) {
            Console.WriteLine("Enter number " + i + ":");
            int num = int.Parse(Console.ReadLine());

            if(num > 0) {
                count++;
            }
        }

        Console.WriteLine("Number of numbers greater than 0 entered: " + count);
    }
}