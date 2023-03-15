// №52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Метод для ввода данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Int32.Parse(Console.ReadLine() ?? "0");
}
// Метод для генерации 2D массива
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
// Метод для печати 2D массива
void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
// Метод для поиска среднего арифметического для каждого столбца
void ArithMean(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        Console.Write(sum / arr.GetLength(0) + "\t");
    }
}

int[,] temp = Gen2DArray(
    ReadData("Введите количество строк:"),
    ReadData("Введите количество столбцов:"),
    ReadData("Введите минимальное значение:"),
    ReadData("Введите максимальное значение:")
);

Print2DArr(temp);
Console.WriteLine();
ArithMean(temp);
