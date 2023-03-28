// Задача №55
// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае,
// если это невозможно, программа должна вывести
// сообщение для пользователя. (Транспонирование)

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

void TranspArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
        }
    }
}

int[,] temp = Gen2DArray(
    ReadData("Введите количество строк:"),
    ReadData("Введите количество столбцов:"),
    ReadData("Введите минимальное значение:"),
    ReadData("Введите максимальное значение:")
);

if (temp.GetLength(0) == temp.GetLength(1))
{
    Print2DArr(temp);
    Console.WriteLine();
    TranspArr(temp);
    Print2DArr(temp);
}
else
{
    Console.WriteLine("Транспонирование невозможно");
}