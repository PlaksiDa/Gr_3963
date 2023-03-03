// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
// числе.
// * Сделать оценку времени алгоритма через вещественные числа и строки

//Метод для вывода
void PrintResult(double line)
{
    Console.WriteLine(line);
}
//Метод для расчёта суммы цифр в числе через остаток
int SumCalcV1(int num)
{
    int result = 0;
    while (num != 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}
//Метод для расчёта суммы цифр в числе через сумму элементов
int SumCalcV2(string num)
{
    int result = 0;
    for (int i = 0; i < num.Length; i++)
    {
        result += Convert.ToInt32(Convert.ToString(num[i]));
    }
    return result;
}

//Вводим число
Console.WriteLine("Введите число:");
string num = Console.ReadLine() ?? "0";

//Создаем переменную с текущим временем
DateTime d1 = DateTime.Now;
//Конверуем строку в число, применяем его в первом методе
PrintResult(SumCalcV1(Convert.ToInt32(num)));
//Выводим разницу, между текущим временем и временем начала операции
Console.WriteLine(DateTime.Now - d1);

//Создаем переменную с текущим временем
d1 = DateTime.Now;
//Конверуем строку в число, применяем его в втором методе
PrintResult(SumCalcV2(num));
//Выводим разницу, между текущим временем и временем начала операции
Console.WriteLine(DateTime.Now - d1);
