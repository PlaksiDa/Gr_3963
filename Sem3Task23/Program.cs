// №23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
// чисел от 1 до N.1
// * Вывести таблицу с границами и значениями друг над другом

// //Вводим число
// Console.WriteLine("Введите число:");
// int n = int.Parse(Console.ReadLine() ?? "0");

// //Вводим степень, в которую нужно возвести число
// Console.WriteLine("Введите степень:");
// int deg = int.Parse(Console.ReadLine() ?? "0");

// //Создаём метод по возведению чисел в степень
// string LineBuilderPow(int num, int pow)
// {
//     string result = string.Empty;
//     for (int i = 1; i <= num; i++)
//     {
//         result = result + Math.Pow(i, pow) + "\t";
//     }
//     return result;
// }

// Console.WriteLine(LineBuilderPow(n, 1));
// Console.WriteLine(LineBuilderPow(n, deg));

// 2 Вариант

//Вводим число
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine() ?? "0");

//Вводим степень, в которую нужно возвести число
Console.WriteLine("Введите степень:");
int deg = int.Parse(Console.ReadLine() ?? "0");

//Ищу длину итоговой таблицы для создания рамки для таблицы
int length = LineBuilderPow(n, deg).Length;

//Создаю метод для создание рамки вокруг таблицы
void Line(string corner1, string corner2)
{
    Console.Write(corner1);
    for (int i = 0; i < length - 1; i++)
    {
        string line = "";
        line = line + "\u2550";
        Console.Write(line);
    }
    Console.Write(corner2);
    Console.WriteLine();
}

//Создаём метод по возведению чисел в степень
string LineBuilderPow(int num, int pow)
{
    string result = string.Empty;
    for (int i = 1; i <= num; i++)
    {
        //В зависимости от длинны числа добавляю ей пробелы так, чтобы цифры стояли в один ряд
        result = result + Math.Pow(i, pow);
        if (Math.Pow(i, pow) > 0 && Math.Pow(i, pow) < 10) result = result + "    " + "\u2551";
        if (Math.Pow(i, pow) >= 10 && Math.Pow(i, pow) < 100) result = result + "   " + "\u2551";
        if (Math.Pow(i, pow) >= 100 && Math.Pow(i, pow) < 1000) result = result + "  " + "\u2551";
        if (Math.Pow(i, pow) >= 1000 && Math.Pow(i, pow) < 10000) result = result + " " + "\u2551";
    }
    return result;
}

Line("\u2554", "\u2557");
Console.WriteLine("\u2551" + LineBuilderPow(n, 1));
Console.WriteLine("\u2551" + LineBuilderPow(n, deg));
Line("\u255A", "\u255D");
