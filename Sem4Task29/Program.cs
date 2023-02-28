// №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// * Ввести с клавиатуры длину массива и диапазон значений элементов 

//Метод для вывода данных
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.WriteLine("]");
}
//Метод для генерации элементов массива
int[] Gen1DArr(int len, int min, int max)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}
//Метод для ввода данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

Print1DArr(Gen1DArr(ReadData("Длина массива: "), ReadData("Минимальная величина элемента массива"), ReadData("Максимальная величина элемента массива")));