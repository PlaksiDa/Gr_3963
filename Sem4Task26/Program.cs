// Задача №26
// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.

// DigitSum(ReadData("Введите число:"));

string ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}
void PrintResult(int line)
{
    Console.WriteLine(line);
}

PrintResult(ReadData("Введите число:").Length);