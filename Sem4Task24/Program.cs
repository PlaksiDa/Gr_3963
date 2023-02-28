// Задача №24
// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

long SumSimple(int numA)
{
    long sum = 0;

    for (int i = 1; i <= numA; i++)
    {
        // sum = sum + i
        sum += i;
    }

    return sum;
}

long SumGausse(int numA)
{
    return ((1 + (long)numA) * (long)numA) / 2;
}

int numA = ReadData("Введите число А:");

DateTime d1 = DateTime.Now;
long res1 = SumSimple(numA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
long res2 = SumGausse(numA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от 1 до А равна:" + res1);
PrintResult("Сумма чисел от 1 до А равна:" + res2);