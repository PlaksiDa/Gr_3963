// №19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов

// //Создаем метод для ввода данных
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// //Создаем метод для проверки на палиндром
// bool PalinTest(int num)

// {
//     bool res = false;
//     if (num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10)
//     {
//         res = true;
//     }
//     return res;
// }

// int n = ReadData("Введите пятизначное число:");

// //Проверяем, является ли число пятизначным
// if (n >= 10000 && n < 100000)
// {
//     //Проверяем, является ли число палиндромом
//     if (PalinTest(n))
//     {
//         Console.WriteLine($"Число {n} является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine($"Число {n} не является палиндромом");
//     }
// }
// else
// {
//     Console.WriteLine("Введено не пятизначное число");
// }

//Вариант 2
//Создаем метод для ввода данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Создаем метод для наполнения словаря, путём добавления одинаковых цифр в начало и конец, и переводим число в четырехзначное
Dictionary<int, int> DictionaryFill()
{
    Dictionary<int, int> dictionary = new Dictionary<int, int>();
    int key = 1;
    for (int secondNum = 0; secondNum <= 9; secondNum++)
    {
        for (int firstNum = 1; firstNum <= 9; firstNum++)
        {
            dictionary[key] = firstNum * 1000 + secondNum * 100 + secondNum * 10 + firstNum;
            key++;
        }
    }
    return dictionary;
}
//Создаем метод для проверки наличия четырехзначного палиндрома в словаре, путём удаления средней цифры из числа
bool PalinTest(int num, Dictionary<int, int> dictionary)
{
    bool result = false;
    if (dictionary.ContainsValue((num / 1000) * 100 + (num % 100)))
    {
        result = true;
    }
    return result;
}

int num = ReadData("Введите число:");

//Заполняем словарь с помощью метода
Dictionary<int, int> palindrome = DictionaryFill();

//Проверяем число на пятизначность
if (num >= 10000 && num < 100000)
{
    //Сравниваем число с имеющимися числами в словаре
    if (PalinTest(num, palindrome))
    {
        Console.WriteLine($"Число {num} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {num} не является палиндромом");
    }
}
else
{
    Console.WriteLine("Число не является пятизначным");
}