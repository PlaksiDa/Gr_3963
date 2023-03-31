// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Метод для ввода данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Int32.Parse(Console.ReadLine() ?? "0");
}
// Метод для генерации 3D массива с неповторяющимися двузначными числами
int[,,] GenUnique3DArray(int countRow, int countColumn, int countDepth, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,,] arr = new int[countRow, countColumn, countDepth];
    // Создаём список, в котом будем хранить числа, которые уже использовались
    List<int> usedValues = new List<int>();
    for (int k = 0; k < countDepth; k++)
    {
        for (int i = 0; i < countRow; i++)
        {
            for (int j = 0; j < countColumn; j++)
            {
                int value;
                // Генерируй случайное число до тех пор, пока его не окажется в списке usedValues
                do
                {
                    value = rnd.Next(minValue, maxValue + 1);
                } while (usedValues.Contains(value));
                usedValues.Add(value);
                arr[k, i, j] = value;
            }
        }
    }
    return arr;
}
// Метод для построчной печати 3D массива с указанием индекса каждого элемента
void Print3DArrWithIndex(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.WriteLine("[{0},{1},{2}] = {3}", i, j, k, arr[i, j, k]);
            }
        }
    }
}

Print3DArrWithIndex(GenUnique3DArray(ReadData("Введите количество строк массива:"), ReadData("Введите количество столбцов массива:"), ReadData("Укажите глубину массива:"), 10, 99));