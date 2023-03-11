// Задача №45
// Напишите программу, которая будет создавать
// копию заданного одномерного массива с помощью
// поэлементного копирования.

//Метод для ввода данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Int32.Parse(Console.ReadLine() ?? "0");
}
//Метод для генерации массива
object[] Gen1DArray(int len, int minValue, int maxValue)
{
    //Блок корректировки входных данных
    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }

    Random rnd = new Random();
    object[] arr = new object[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue + 1);
    }
    return arr;
}
//Метод для печати массива
void Print1DArr(object[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
//Метод для копирования массива
object[] CopyArrayStandartTools(params object[] inputArr)
{
    object[] outArr = new object[inputArr.Length];
    //Копируем массив inputAdd в outArr, начиная с элемента 0
    inputArr.CopyTo(outArr, 0);
    return outArr;
}

object[] temp = Gen1DArray(ReadData("Введите длину массива: "), ReadData("Введите минимальный элемент массива: "), ReadData("Введите максимальный элемент массива: "));
Print1DArr(temp);
Print1DArr(CopyArrayStandartTools(temp));