// Задача №53
// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю
// строку массива.

// Метод для ввода данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Int32.Parse(Console.ReadLine() ?? "0");
}
// Метод для генерации 2D массива
void Gen2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
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
// Метод для замены местами первой и последней строки массива
void Change2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        (matr[0, i], matr[matr.GetLength(0) - 1, i]) = (matr[matr.GetLength(0) - 1, i], matr[0, i]);

    }
}

int m = ReadData("Введите количество строк:");
int n = ReadData("Введите количество стобцов:");
int[,] matrix = new int[m, n];
Gen2DArray(matrix, 1, 100);
Print2DArr(matrix);
Change2DArray(matrix);
Console.WriteLine();
Print2DArr(matrix);