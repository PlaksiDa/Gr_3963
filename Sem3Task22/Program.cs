// Задача №22
// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел от 1 до
// N.;

//Вводим число
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine() ?? "0");

//Вводим степень, в которую хотим возвести число
Console.WriteLine("Введите степень:");
int deg = int.Parse(Console.ReadLine() ?? "0");

//Создаём метод по возведению чисел в степень
string LineBuilderPow(int num, int pow)
{
    string result = string.Empty;
    for (int i = 1; i <= num; i++)
    {
        result = result + Math.Pow(i, pow) + "\t";
    }
    return result;
}

Console.WriteLine(LineBuilderPow(n, 1));
Console.WriteLine(LineBuilderPow(n, deg));