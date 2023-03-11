// Задача №40
// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.

//Метод для ввода данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Int32.Parse(Console.ReadLine() ?? "0");
}
//Метод для вывода данных
void PrintResult(string line)
{
    Console.WriteLine(line);
}
//Метод для проверки длины строн треугольника
bool Test(int a, int b, int c)
{
    return a <= b + c;
}
//Метод для проверки всех длин строн треугольника
bool TriangleTest(int a, int b, int c)
{
    bool result = false;
    if (Test(a, b, c) && Test(b, a, c) && Test(c, a, b)) result = true;
    return result;
}

if (TriangleTest(ReadData("Введите a:"), ReadData("Введите b:"), ReadData("Введите c:"))) PrintResult("Такой треугольник может существовать");
else PrintResult("Такой треугольник не может существовать");