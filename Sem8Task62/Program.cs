// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

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
// Метод для заполнения и печати массива спирально
void Fill2DArrayInSpiral(int[,] arr)
{
    int count = 1;
    int minRow = 0;
    int maxRow = arr.GetLength(0) - 1;
    int minCol = 0;
    int maxCol = arr.GetLength(1) - 1;

    while (count <= arr.Length)
    {
        for (int i = minCol; i <= maxCol; i++)
        {
            arr[minRow, i] = count++;
        }

        for (int i = minRow + 1; i <= maxRow; i++)
        {
            arr[i, maxCol] = count++;
        }

        for (int i = maxCol - 1; i >= minCol; i--)
        {
            arr[maxRow, i] = count++;
        }

        for (int i = maxRow - 1; i > minRow; i--)
        {
            arr[i, minCol] = count++;
        }

        minRow++;
        maxRow--;
        minCol++;
        maxCol--;
    }

    // Выводим массив на консоль
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int countRow = ReadData("Введите количество строк:");
int countColumn = ReadData("Введите количество столбцов:");
int minValue = ReadData("Введите минимальное значение:");
int maxValue = ReadData("Введите максимальное значение:");

Fill2DArrayInSpiral(Gen2DArray(countRow, countColumn, minValue, maxValue));