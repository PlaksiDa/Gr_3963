// Задача №28
// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.

using System.Numerics;

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}
void PrintResult(BigInteger line)
{
    Console.WriteLine(line);
}

BigInteger FactorCalc(int num)
{
    BigInteger res = 1;
    for (int i = 1; i <= num; i++)
    {
        res = res * i;
    }
    return res;
}
PrintResult(FactorCalc(ReadData("Введите число:")));