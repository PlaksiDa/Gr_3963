// №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
// * Найдите площадь треугольника образованного пересечением 3 прямых

// Метод для ввода данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Int32.Parse(Console.ReadLine() ?? "0");
}
// Метод который находит x и y для точки пересечения двух отрезков, в зависимости от k и b
(double x, double y) CrossPoint(int k1, int b1, int k2, int b2)
{
    int x = (b2 - b1) / (k1 - k2);
    int y = k1 * x + b1;
    return (x, y);
}
// Метод для нахождения расстояния между двумя точками с помощью гипотенузы
double SideLength((double x, double y) firstPoint, (double x, double y) secondPoint)
{
    // a^2 = (b1-b2)^2 + (c1-c2)^2
    double result = Math.Sqrt(Math.Pow(secondPoint.x - firstPoint.x, 2) + Math.Pow(secondPoint.y - firstPoint.y, 2));
    return result;
}
// Метод для нахождения площади треугольника
double Sqr(double a, double b, double c)
{
    // Полупериметр треугольника s = (a + b + c) / 2
    double HalfPer = (a + b + c) / 2;
    // Площадь треугольника S = sqrt(s * (s - a) * (s - b) * (s - c))
    double sqr = Math.Sqrt(HalfPer * (HalfPer - a) * (HalfPer - b) * (HalfPer - c));
    return sqr;
}

// Вводим коэффициенты k и b для каждого уравнения
(int k, int b) equat1 = (ReadData("Введите k1:"), ReadData("Введите b1:"));
(int k, int b) equat2 = (ReadData("Введите k2:"), ReadData("Введите b2:"));
(int k, int b) equat3 = (ReadData("Введите k3:"), ReadData("Введите b3:")); Console.WriteLine();

// Ищем x и y для каждой из точек пересечения
(double x, double y) a = CrossPoint(equat1.k, equat1.b, equat2.k, equat2.b);
(double x, double y) b = CrossPoint(equat1.k, equat1.b, equat3.k, equat3.b);
(double x, double y) c = CrossPoint(equat2.k, equat2.b, equat3.k, equat3.b);

// Выводим координаты точек пересечения в консоль
Console.WriteLine("Точка пересечения a по координатам: " + a);
Console.WriteLine("Точка пересечения b по координатам: " + b);
Console.WriteLine("Точка пересечения c по координатам: " + c); Console.WriteLine();

// Ищем расстояние между точками пересечения
double aLength = SideLength(a, b);
double bLength = SideLength(a, c);
double cLength = SideLength(b, c);

// Выводим расстояние в виде длины отрезков
Console.WriteLine("Длинна отрезка А: " + aLength);
Console.WriteLine("Длинна отрезка B: " + bLength);
Console.WriteLine("Длинна отрезка C: " + cLength); Console.WriteLine();

// Находим площадь треугольника, образованного отрезкми
Console.WriteLine("Площадь треугольника: " + Sqr(aLength, bLength, cLength)); Console.WriteLine();