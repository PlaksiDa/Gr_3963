// №4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из
// этих чисел.

Console.WriteLine("Введите первое число:");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int numB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int numC = Convert.ToInt32(Console.ReadLine());

//№1 Вариант

// if (numA > numB)
// {
//     if (numA > numC)
//     {
//         Console.WriteLine("Наибольшее число:" + numA);
//     }
//     else
//     {
//         Console.WriteLine("Наибольшее число:" + numB);
//     }
// }
// else
// {
//     if (numB > numC)
//     {
//         Console.WriteLine("Наибольшее число:" + numB);
//     }
//     else
//     {
//         Console.WriteLine("Наибольшее число:" + numC);
//     }
// }

//№2 Вариант

// int[] num = { numA, numB, numC };
// Console.WriteLine("Максимальное число: " + num.Max());

//№3 Вариант

int max = numA > numB ? numA > numC ? numA : numC : numB > numC ? numB : numC;
Console.WriteLine("Максимальное число: " + max);