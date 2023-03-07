// Задача №37
// Найдите произведение пар чисел в одномерном
// массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат
// запишите в новом массиве.

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

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] ConvertArray(int[] array)
{
    int[] buffArr = new int[array.Length / 2 + 1];
    for (int i = 0; i < array.Length / 2 + 1; i++)
    {
        buffArr[i] = array[i] * array[array.Length - 1 - i];
    }
    return buffArr;
}

int[] temp = Gen1DArray(10, 1, 10);
Print1DArr(temp);
Print1DArr(ConvertArray(temp));