/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

class Program {
    public static void Main (string[] args) {
        double k1, k2, b1, b2, x, y;

        Console.WriteLine("Enter values for k1, b1, k2, and b2: ");
        k1 = Convert.ToDouble(Console.ReadLine());
        b1 = Convert.ToDouble(Console.ReadLine());
        k2 = Convert.ToDouble(Console.ReadLine());
        b2 = Convert.ToDouble(Console.ReadLine());

        if (k1 == k2) {
            string message = b1 == b2 ? "lines are equal" : "lines are parallel";
            Console.WriteLine(message);
            return;
        }

        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;

        Console.WriteLine("The point of intersection is at (" + x + "," + y + ")");
    }
}
