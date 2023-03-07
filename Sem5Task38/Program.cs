// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементом массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите
// разницу между первым и последним элементом. Для задачи со звездочкой
// использовать заполнение массива целыми числами.

//Метод для печати массива в консоль
void Print1DArr(double[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + " | ");
    }
    Console.WriteLine(arr[arr.Length - 1] + " ]");
}
//Метод для генерации массива
double[] Gen1DArray(int len)
{
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
    return arr;
}
//Метод для ввода данных из консоли
double ReadData(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToDouble(Console.ReadLine() ?? "0");
}
//Метод для вывода данных в консоль
void PrintData(string res, double value)
{
    Console.WriteLine(res + value);
}
//Метод для поиска разницы между максимальным и минимальным элементом массива
double MaxMin(double[] array)
{
    double min = double.MaxValue;
    double max = double.MinValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return max - min;
}

double[] temp = Gen1DArray(Convert.ToInt32(ReadData("Введите длину массива: ")));
Print1DArr(temp);
PrintData("Разница между максимальным и минимальным элементом массива: ", MaxMin(temp));