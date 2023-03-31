// Задача 64: 
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
// Выполнить с помощью рекурсии.

// Метод для ввода данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Int32.Parse(Console.ReadLine() ?? "0");
}
//Метод для выведения всех натуральных чисел, в промежутке от 1 до N. 
void LineGenetatorRec(int numMin, int numMax)
{
    Console.Write(numMin + " ");
    if (numMax == 1) { }
    else LineGenetatorRec(numMin + 1, numMax - 1);
}

LineGenetatorRec(1, ReadData("Введите N:"));