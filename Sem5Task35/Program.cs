// Задача №35
// Задайте одномерный массив из 123 случайных
// чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].

//Метод для печати массива в консоль
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
//Метод для генерации массива
int[] Gen1DArray(int len, int minValue, int maxValue)
{
    //Блок корректировки входных данных
    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }

    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue + 1);
    }
    return arr;
}
//Метод для подсчёта чисел входящих в указанный диапазон
int NumElemInRange(int[] array, int minValue, int maxValue)
{
    int results = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= minValue && array[i] <= maxValue) results++;
    }
    return results;
}
//Метод для вывода данных в консоль
void PrintResult(int line)
{
    Console.WriteLine(line);
}
//Метод для ввода данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Int32.Parse(Console.ReadLine() ?? "0");
}

int[] temp = Gen1DArray(ReadData("Введите длину массива: "), ReadData("Введите минимальный элемент массива: "), ReadData("Введите максимальный элемент массива: "));
Print1DArr(temp);
PrintResult(NumElemInRange(temp, 10, 99));