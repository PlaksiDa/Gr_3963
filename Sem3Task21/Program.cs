// №21 Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.

//Содаём метод, который возвращает введенное значение.
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Создаем метод по выводу итоговых сообщений.
void PrintData(string msg, double value)
{
    Console.WriteLine(msg + value);
}

//Создаем метод для нахождения гипотенузы - расстояния между двумя точками.
double CalcLen2D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
}

PrintData("Расстояние между двумя точками: ", CalcLen2D(
    ReadData("Введите X для точки A:"), ReadData("Введите Y для точки A:"), ReadData("Введите Z для точки A:"),
    ReadData("Введите X для точки B:"), ReadData("Введите Y для точки B:"), ReadData("Введите Z для точки B:")));