// Задача 65.
// Задайте значение m n. Напишите программу, которая найдет 
// все натуральные элементы в промежутке от m до n.

// Метод для ввода данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Int32.Parse(Console.ReadLine() ?? "0");
}
// Метод для вывода
void PrintResult(string line)
{
    Console.WriteLine(line);
}

string RecMN(int m, int n)
{
    string result = string.Empty;
    if (m >= n) result = n.ToString();
    else
    {
        result = result + m + " " + RecMN(m + 1, n);
    }
    return result;
}
int m = ReadData("m");
int n = ReadData("n");
PrintResult(m < n ? RecMN(m, n) : RecMN(n, m));