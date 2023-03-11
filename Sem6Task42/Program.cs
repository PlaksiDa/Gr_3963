// Задача №42
// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

//Метод для ввода данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Int32.Parse(Console.ReadLine() ?? "0");
}
//Метод для вывода данных
void PrintResult(string line)
{
    Console.WriteLine(line);
}
//Метод для перевода числа из десятичного формата в двоичный
// string DecToBin(int num)
// {
//     string result = string.Empty;
//     while (num > 0)
//     {
//         result = num % 2 + result;
//         num /= 2;
//     }
//     return result;
// }
//
string DecToBinNative(int num, int baseI)
{
    return Convert.ToString(num, baseI);
}
int num = ReadData("Введите число:");
// PrintResult(DecToBin(num));
PrintResult("В двоичной системе: " + DecToBinNative(num, 2));
PrintResult("В восьмиричной системе: " + DecToBinNative(num, 8));
PrintResult("В шестнадцатиричной системе: " + DecToBinNative(num, 16));