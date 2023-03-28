// Задача №59
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и
// столбец, на пересечении которых расположен
// наименьший элемент массива.

//Метод для ввода данных из консоли
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
// Метод для удаления строки и столбеца, на пересечении которых расположен искомый элемент
int[,] Update2DArray(int[,] arr, int x, int y)
{
    int[,] outArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int k = 0;
    int m = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        m = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i != x && j != y) outArr[k, m] = arr[i, j];
            if (j != y) m++;
        }
        if (i != x) k++;
    }
    return outArr;
}
// Метод по поиску местоположения для минимально элемента массива
(int x, int y) SearchMinElement2DArray(int[,] matrix)
{
    int row = 0;
    int column = 0;
    int min = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                row = i;
                column = j;
            }
        }
    }
    return (row, column);
}

int countRow = ReadData("Введите количество строк:");
int countColumn = ReadData("Введите количество столбцов:");
int minValue = ReadData("Введите минимальное значение:");
int maxValue = ReadData("Введите максимальное значение:");

int[,] temp = Gen2DArray(countRow, countColumn, minValue, maxValue);
Print2DArr(temp);
Console.WriteLine();
(int x, int y) num = SearchMinElement2DArray(temp);
Print2DArr(Update2DArray(temp, num.x, num.y));