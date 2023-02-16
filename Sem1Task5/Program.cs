// Задача №5
// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.

string? lineN = Console.ReadLine();

if (lineN != null)
{
    int n = int.Parse(lineN);
    string res = string.Empty;
    int negN = n * (-1);
    while (negN <= n)
    {
        res = res + negN + " ";
        negN++;
        Console.WriteLine(res);
    }
    Console.WriteLine(res);
}
