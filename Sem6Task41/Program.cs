// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и
// выдает сколько чисел больше 0 было введено.

using System.Text.RegularExpressions;

// Ввода данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Int32.Parse(Console.ReadLine() ?? "0");
}
// Возвращает строку со всеми введенными символами
string Test(int n)
{
    string res = string.Empty;
    for (int i = 0; i < n; i++)
    {
        string temp = Console.ReadKey(true).KeyChar.ToString();
        if (temp == "-") res += "-" + Console.ReadKey(true).KeyChar.ToString();
        else res += temp;
    }
    return res;
}
// В строке text ищем определенную последовательность символов pattern. Совпадения выводятся в консоль с текстом name1, количество совпадений выводится в консоль с текстом name2
void Test2(string text, string pattern, string name1, string name2)
{
    // Искомой строке присваем тип данных Regex
    Regex regex = new Regex(pattern);
    // С помощью метода Matches ищем в text строку regex
    MatchCollection matches = regex.Matches(text);
    Console.Write(name1);
    // Для каждого обьекта Match в matches пишем его значение в консоль
    foreach (Match match in matches)
    {
        Console.Write(match.Value + ", ");
    }
    Console.WriteLine();
    // Выводим в консоль счетчик количества совпадений
    Console.WriteLine(name2 + matches.Count);
}

string text = Test(ReadData("Число нажатий:"));
Console.WriteLine("Введеная строка: " + text);
Test2(text, @"-\d+", "Отрицательные числа: ", "Количество отрицательных чисел: ");