// Задача №31
// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных
// элементов массива.

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

    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
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
//Метод для вывода данных в консоль
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}
//Метод для суммирования положительных и отрицательных элементов массива
(int posit, int negot) NegPosSum(int[] arr)
{
    int positSum = 0;
    int negotSum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positSum += arr[i];
        }
        else
        {
            negotSum += arr[i];
        }
    }
    return (positSum, negotSum);
}

int[] testArr = Gen1DArray(12, -9, 9);
Print1DArr(testArr);
(int posit, int negot) results = NegPosSum(testArr);
PrintData("Сумма положительных чисел в массиве:  ", results.posit);
PrintData("Сумма отрицательных чисел в массиве: ", results.negot);