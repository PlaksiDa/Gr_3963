// Задача №7
// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе
// показывает последнюю цифру этого числа.

// string? lineN = Console.ReadLine();
// if (lineN != null)
// {
//     int n = int.Parse(lineN);
//     int res = n % 10;
//     Console.WriteLine("Последняя цифра: "+res);
// }

Console.WriteLine("Введите число: ");
var number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    Console.WriteLine("Последняя цифра числа:" + number % 10);
}
else
{
    Console.WriteLine("Введено не то число");
}