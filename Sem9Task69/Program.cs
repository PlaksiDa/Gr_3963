// Задача 69
// напишите программу, которая будет принимать два числа a и b и она возведет a в степень b.

// Метод для ввода данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Int32.Parse(Console.ReadLine() ?? "0");
}
// Метод для вывода
void PrintResult(long line)
{
    Console.WriteLine(line);
}
// // Метод для возведения числа a, в степень b
// long RecPow(int a, int b)
// {
//     if (b <= 1) return a;
//     else
//     {
//         return a * RecPow(a, b - 1);
//     }
// }

// PrintResult(RecPow(ReadData("Введите число a:"), ReadData("Введите степень b:")));

long MyPow(int a, int b)
{
    if (b == 2)
    {
        return 4;
    }
    else
    {
        return MyPow(a, b / 2) * MyPow(a, b / 2);
    }
}

PrintResult(MyPow(ReadData("Введите число a:"), ReadData("Введите степень b:")));