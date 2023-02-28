// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
// * Написать калькулятор с операциями +, -, /, * и возведение в степень

// // Вариант 1

// // Метод для ввода данных
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }
// // Метод для вывода данных
// void PrintResult(long line)
// {
//     Console.WriteLine(line);
// }
// // Метод для возведения в степень
// long Pow(int a, int b)
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result = result * a;
//     }
//     return result;
// }

// PrintResult(Pow(ReadData("Введите число: "), ReadData("Введите степень: ")));

// 2 Вариант
// Метод для ввода данных
string ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}
// Метод для вывода данных
void PrintResult(double line)
{
    Console.WriteLine(line);
}
// Метод, который в зависимости от знака применяет тот или иной математический оператор
double Calculator(double a, string sign, double b)
{
    double result = 0;
    if (sign == "+") result = a + b;
    if (sign == "-") result = a - b;
    if (sign == "*") result = a * b;
    if (sign == "/") result = a / b;
    if (sign == "^") result = Math.Pow(a, b);
    return result;
}

PrintResult(Calculator(Convert.ToDouble(ReadData("Введите первое число:")), Convert.ToString(ReadData("Введите оператор(+, -, /, *, ^):")), Convert.ToDouble(ReadData("Введите второе число:"))));