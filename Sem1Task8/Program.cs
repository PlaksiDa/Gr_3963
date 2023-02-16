// №8 Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
int numN = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= numN; i = i + 2)
{
    Console.Write(i + " ");
}