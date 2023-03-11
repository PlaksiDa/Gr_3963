// Задача №44
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

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
//Метод дял поиска числа фибаначи
string FibNum(int num)
{
    string result = "0 1";
    int first = 0;
    int last = 1;
    for (int i = 2; i < num; i++)
    {
        result = result + " " + (first + last).ToString();
        (first, last) = (last, first + last);
    }

    return result;
}

PrintResult(FibNum(ReadData("Введите число:")));