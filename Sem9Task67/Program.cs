// Задача 67
// Программа, которая принимает на вход число, а возвращает сумму цифр этого числа.

// Метод для ввода данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Int32.Parse(Console.ReadLine() ?? "0");
}
// Метод для вывода
void PrintResult(int line)
{
    Console.WriteLine(line);
}

int RegSumDig(int num)
{
    if (num == 0) return 0;
    else return num % 10 + RegSumDig(num / 10);
}

PrintResult(RegSumDig(ReadData("Число")));