// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю

// //Вариант 1

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
// //Метод для вывода данных в консоль
// void PrintData(string res, int value)
// {
//     Console.WriteLine(res + value);
// }
// //Метод для ввода данных из консоли
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return Int32.Parse(Console.ReadLine() ?? "0");
// }
// //Метод для подсчёта суммы элементов, стоящих на нечётных позициях
// int OddSum(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i += 2)
//     {
//         result += array[i];
//     }
//     return result;
// }

// int[] temp = Gen1DArray(ReadData("Введите длину массива: "), ReadData("Введите минимальный элемент массива: "), ReadData("Введите максимальный элемент массива: "));
// Print1DArr(temp);
// PrintData("Сумма элементов, стоящих на нечётных позициях: ", OddSum(temp));

//Вариант 2

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
//Метод для ввода данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Int32.Parse(Console.ReadLine() ?? "0");
}
//Метод для поиска пар в массиве
void PairsArray(int[] arr)
{
    //Поочередно сравниваем значение первого элемента массива с последующими, пока не найдем пару
    for (int i1 = 0; i1 < arr.Length - 1; i1++)
    {
        //Если пара для первого элемента не нашлась, берем следующий и повторяем цикл
        for (int i2 = i1 + 1; i2 < arr.Length; i2++)
        {
            //Если пара нашлась, выводим сообщение и присваем им значение -1, чтобы исключить их из дальнейшего сравнения
            if (arr[i1] == arr[i2] && arr[i1] >= 0)
            {
                Console.WriteLine($"Пара {arr[i1]} на позициях {i1} и {i2}");
                arr[i1] = -1;
                arr[i2] = -1;
            }
        }
    }
}

int[] temp = Gen1DArray(ReadData("Введите длину массива: "), ReadData("Введите минимальный элемент массива: "), ReadData("Введите максимальный элемент массива: "));
Print1DArr(temp);
PairsArray(temp);
Print1DArr(temp);