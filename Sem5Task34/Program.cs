// №34 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1
// * Отсортировать массив методом пузырька
// ** Отсортировать массив методом подсчета

//Вариант 1

// //Метод для генерации массива
// int[] Gen1DArray(int len, int minValue, int maxValue)
// {
//     //Блок корректировки входных данных
//     if (minValue > maxValue)
//     {
//         int buf = minValue;
//         minValue = maxValue;
//         maxValue = buf;
//     }

//     Random rnd = new Random();
//     int[] arr = new int[len];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(minValue, maxValue + 1);
//     }
//     return arr;
// }
// //Метод для печати массива в консоль
// void Print1DArr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "]");
// }
// //Метод для ввода данных из консоли
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return Int32.Parse(Console.ReadLine() ?? "0");
// }
// //Метод для подсчета чётных чисел в массиве
// void EvenNum(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) result += 1;
//     }
//     Console.WriteLine("Количество чётных чисел: " + result);
// }

// int[] array = Gen1DArray(ReadData("Введите длину массива:"), 100, 999);
// Print1DArr(array);
// EvenNum(array);

//Вариант 2

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
//Метод для ввода данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Int32.Parse(Console.ReadLine() ?? "0");
}
//Метод сортировки пузырьком
int[] Sort(int[] arr)
{
    int length = arr.Length;
    int buff = 0;
    while (length > 0)
    {
        for (int i = 0; i < length - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                buff = arr[i + 1];
                arr[i + 1] = arr[i];
                arr[i] = buff;
            }
        }
        length -= 1;
    }
    return arr;
}

int[] array = Gen1DArray(ReadData("Введите длину массива: "), ReadData("Введите минимальный элемент массива: "), ReadData("Введите максимальный элемент массива: "));
Print1DArr(array);
Print1DArr(Sort(array));
