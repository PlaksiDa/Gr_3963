// Задача №18
// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных
// координат точек в этой четверти (x и y).

//Содаём метод, который выводит введенную координату и возвращает её.
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Содаём метод, который в зависимости от введенного числа выводит определенный текст.
void ProntAnswer(int num)
{
    if (num > 0 && num < 5)
    {
        if (num == 1) Console.WriteLine("x > 0, y > 0");
        if (num == 2) Console.WriteLine("x > 0, y < 0");
        if (num == 3) Console.WriteLine("x < 0, y < 0");
        if (num == 4) Console.WriteLine("x < 0, y > 0");
    }
    else
    {
        Console.WriteLine("Неверное число");
    }
}

int num = ReadData("Введите номер четверти: ");
ProntAnswer(num);
