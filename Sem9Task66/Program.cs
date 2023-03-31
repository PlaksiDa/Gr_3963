// Задача 66: 
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

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
// Метод для суммирования натуральных элементов в промежутке от M до N
int RegSumDigMN(int m, int n)
{
    if (m >= n) return n;
    else return m + RegSumDigMN(m + 1, n);
}

PrintResult(RegSumDigMN(ReadData("Введите m:"), ReadData("Введите n:")));