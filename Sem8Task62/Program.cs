// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// rnd.Next(minValue, maxValue + 1);
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
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[0, j] = rnd.Next(minValue, maxValue + 1);
    }
    for (int i = 0; i < arr.GetLength(0) - 1; i++)
    {
        arr[i + 1, arr.GetLength(1) - 1] = rnd.Next(minValue, maxValue + 1);
    }
    for (int j = arr.GetLength(1) - 2; j >= 0; j--)
    {
        arr[arr.GetLength(0) - 1, j] = rnd.Next(minValue, maxValue + 1);
    }
    for (int i = arr.GetLength(0) - 2; i > 0; i--)
    {
        arr[i, 0] = rnd.Next(minValue, maxValue + 1);
    }
    for (int j = 1; j < arr.GetLength(1) - 1; j++)
    {
        arr[1, j] = rnd.Next(minValue, maxValue + 1);
    }
    for (int j = 2; j > 0; j--)
    {
        arr[2, j] = rnd.Next(minValue, maxValue + 1);
    }
    return arr;

}
// Метод для заполнения и печати массива спирально
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


Print2DArr(Gen2DArray(4, 4, 1, 9));