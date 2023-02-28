// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
// числе.
// * Сделать оценку времени алгоритма через вещественные числа и строки

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintResult(double line)
{
    Console.WriteLine(line);
}

int SumCalc(int num)
{
    int result = 0;
    for (int i = 1; i <= num; i++)
    {
        result = result + i;
    }
    return result;
}
PrintResult(SumCalc(ReadData("Введите число: ")));
// DateTime d1 = DateTime.Now;
// Console.WriteLine(DateTime.Now - d1);