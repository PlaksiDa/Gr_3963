// Задача №57
// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается
// элемент входных данных.

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
//Метод для печати массива
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
// Метод для заполнения частотного словаря
int[] FreqDisBuild(int[,] arr, int maxValue, int minValue)
{
    int[] dic = new int[maxValue - minValue];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            dic[arr[i, j] - minValue]++;

        }
    }
    return dic;
}

int countRow = ReadData("Введите количество строк:");
int countColumn = ReadData("Введите количество столбцов:");
int minValue = ReadData("Введите минимальное значение:");
int maxValue = ReadData("Введите максимальное значение:");

int[,] temp = Gen2DArray(countRow, countColumn, minValue, maxValue);
Print2DArr(temp);
Console.WriteLine();
Print1DArr(FreqDisBuild(temp, maxValue + 1, minValue));