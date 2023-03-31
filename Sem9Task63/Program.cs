// Задача 63.
// Задайте значение N. Напиши программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии

// Метод для ввода данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Int32.Parse(Console.ReadLine() ?? "0");
}
//
void LineGenetatorRec(int num)
{
    Console.Write(num + " ");
    if (num == 1)
    {
    }
    else
    {
        LineGenetatorRec(num - 1);
    }
}

LineGenetatorRec(ReadData("Введите N:"));