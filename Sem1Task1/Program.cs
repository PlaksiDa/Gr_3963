// Задача №1
// Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число
// квадратом второго.

Console.Clear();

Console.WriteLine("Введите первое число: ");
string numLine1 = Console.ReadLine() ?? "0";

Console.WriteLine("Введите второе число число: ");
string numLine2 = Console.ReadLine() ?? "0";

if (numLine1 != null && numLine2 != null)
{
    int num1 = int.Parse(numLine1);
    int num2 = int.Parse(numLine2);

    if (num1 == (int)Math.Pow(num2, 2))
    {
        Console.WriteLine($"Число {num1} является квадратом числа {num2}");
    }
    else
    {
        Console.WriteLine($"Число {num1} не является квадратом числа {num2}");
    }
}