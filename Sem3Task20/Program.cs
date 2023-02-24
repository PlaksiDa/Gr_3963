// Задача №20
// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.

//Содаём метод, который выводит введенную координату и возвращает её.
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

//Создаем метод для нахождения гипотенузы - расстояние между двумя точками.
double CalcLen2D(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
}

PrintData("Расстояние между двумя точками: ", CalcLen2D(ReadData("Введите x для точки A:"), ReadData("Введите y для точки A:"), ReadData("Введите x для точки B:"), ReadData("Введите y для точки B:")));