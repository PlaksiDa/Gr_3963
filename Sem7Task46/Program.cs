// Задача №46
// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.

// Метод для ввода данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Int32.Parse(Console.ReadLine() ?? "0");
}

// Метод для генерации массива
int[,] Gen2DArray(int countRow, int countColumn, int minValue, int maxValue)
{
    // Блок корректировки входных данных
    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }
    Random rnd = new Random();
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return arr;
}

// Метод для печати массива
void Print2DArr(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[] {
        ConsoleColor.Black, ConsoleColor.DarkBlue, ConsoleColor.DarkGreen,
        ConsoleColor.DarkCyan, ConsoleColor.DarkRed, ConsoleColor.DarkRed,
        ConsoleColor.DarkMagenta, ConsoleColor.DarkYellow };
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0, 8)];
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

Print2DArr(Gen2DArray(
    ReadData("Введите количество строк:"),
    ReadData("Введите количество столбцов:"),
    ReadData("Введите минимальное значение:"),
    ReadData("Введите максимальное значение:"))
);