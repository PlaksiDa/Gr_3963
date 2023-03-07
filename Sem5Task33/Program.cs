// Задача №33
// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в
// массиве.

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
//Метод для поиска заданного числа в массиве
int SearchElem(int[] arr, int elem)
{
    int result = -1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == elem)
        {
            result = i;
            break;
        }
    }
    return result;
}
//Метод для ввода данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Int32.Parse(Console.ReadLine() ?? "0");
}

int[] temp = Gen1DArray(ReadData("Введите длину массива: "), ReadData("Введите минимальный элемент массива: "), ReadData("Введите максимальный элемент массива: "));
Print1DArr(temp);
int SearchNum = SearchElem(temp, ReadData("Введите искомое число: "));

if (SearchNum >= 0)
{
    Console.WriteLine("Искомое число на " + SearchNum + " позиции");
}
else
{
    Console.WriteLine("Такого числа нет в массиве");
}