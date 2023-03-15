// №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру

// Метод для ввода данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Int32.Parse(Console.ReadLine() ?? "0");
}
// Метод для расчёта числа фибоначчи
int Fibonacci(int n)
{
    if (n <= 1) return n;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
// Метод для генерации массива
int[,] Gen2DArray(int countRow, int countColumn)
{
    int[,] arr = new int[countRow, countColumn];
    int n = 0;

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = Fibonacci(n);
            n++;
        }
    }
    return arr;
}
// Метод для печати массива
void Print2DArr(int[,] arr, int searchRow, int searchColumn)
{
    // Список всех цветов, присвоинных массиву col
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (searchRow == i && searchColumn == j)
            {
                // Если искомый элемент массива совпадает с текущим, смени цвет шрифта, напечатай элемент в консоль и верни стандартный цвет
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(arr[i, j] + "\t");
                Console.ResetColor();
            }
            else Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    // Если искомого элемента нет, выведи в консоль сообщение
    if (searchRow > arr.GetLength(1) - 1 || searchColumn > arr.GetLength(0) - 1) Console.WriteLine("Искомого элемента в массиве нет");
}


int[,] temp = Gen2DArray(ReadData("Введите количество строк:"), ReadData("Введите количество столбцов:"));
Print2DArr(temp, ReadData("Введите искомую строку:"), ReadData("Введите искомый столбец:"));