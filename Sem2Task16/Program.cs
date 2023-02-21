// Задача №16
// Напишите программу, которая принимает на вход
// два числа и проверяет, является ли одно число
// квадратом другого. 

int numA = int.Parse(Console.ReadLine() ?? "0");
int numB = int.Parse(Console.ReadLine() ?? "0");

void SqeaTest(int num1, int num2)
{
    if(num1 == num2 * num2)
    {
        Console.WriteLine($"Число {num1} квадрат числа {num2}");
    }
    else
    {
        Console.WriteLine($"Число {num1} не квадрат числа {num2}");
    }
}

SqeaTest(numA, numB);
SqeaTest(numB, numA);