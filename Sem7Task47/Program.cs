// №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

// Метод для ввода данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Int32.Parse(Console.ReadLine() ?? "0");
}
// Метод для генерации массива
double[,] Gen2DArray(int countRow, int countColumn, int minValue, int maxValue)
{
    // Блок корректировки входных данных
    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }
    double[,] arr = new double[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            // Оставить две цифры после запятой в формуле нахождения случайного числа, в промежутке от minValue до max Value, и присвоить их arr[i, j]
            arr[i, j] = Math.Round(minValue + (maxValue - minValue) * new Random().NextDouble(), 2);
        }
    }
    return arr;
}
// Метод для печати массива
void Print2DArr(double[,] arr)
{
    // Список всех цветов, присвоинных массиву col
    ConsoleColor[] col = new ConsoleColor[] {
        ConsoleColor.Black, ConsoleColor.DarkBlue, ConsoleColor.DarkGreen,ConsoleColor.DarkCyan,
        ConsoleColor.DarkRed,ConsoleColor.DarkMagenta, ConsoleColor.DarkYellow, ConsoleColor.Gray,
        ConsoleColor.DarkGray, ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.Cyan,
        ConsoleColor.Red, ConsoleColor.Magenta, ConsoleColor.Yellow, ConsoleColor.White
    };
    // Строки
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        // Столбцы
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // Каждый элемента массива переводим в строку и последовательно выводим каждый символ строки, меняя цвет
            string temp = arr[i, j].ToString();
            for (int k = 0; k < temp.Length; k++)
            {
                Console.ForegroundColor = col[new Random().Next(0, 15)];
                Console.Write(temp[k]);
            }
            Console.Write("\t");
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