// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
// Метод для нахождения произведения двух матриц
int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    // Создание результирующей матрицы
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

    // Вычисление произведения матриц
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            result[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return result;
}

int countRow = ReadData("Введите количество строк:");
int countColumn = ReadData("Введите количество столбцов:");
int minValue = ReadData("Введите минимальное значение:");
int maxValue = ReadData("Введите максимальное значение:");

int[,] matrix1 = Gen2DArray(countRow, countColumn, minValue, maxValue);
int[,] matrix2 = Gen2DArray(countRow, countColumn, minValue, maxValue);

Console.WriteLine("Первая матрица:");
Print2DArr(matrix1);

Console.WriteLine("Вторая матрица:");
Print2DArr(matrix2);

Console.WriteLine("Результат произведения:");
Print2DArr(MultiplyMatrices(matrix1, matrix2));

