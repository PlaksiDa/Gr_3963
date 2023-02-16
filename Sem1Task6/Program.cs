// №6 Напишите программу, которая на вход принимает число и выдаёт, является ли число
// чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
int numA = Convert.ToInt32(Console.ReadLine());

if (numA % 2 == 0)
{
    Console.WriteLine($"Число {numA} чётное");
}
else
{
    Console.WriteLine($"Число {numA} не чётное");
}