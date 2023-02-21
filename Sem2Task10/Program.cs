// №10 Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.

// // Проверяю на ноль
// int num = int.Parse(Console.ReadLine() ?? "0");
// // Нахожу второе число путём деления на 10 и поиска остатка от деления еще раз на 10
// int secondDigit = num / 10 % 10;
// // Вывод
// Console.WriteLine(secondDigit);

// 2 Способ

// Перевожу в число и проверяю на ноль
int numbers = int.Parse(Console.ReadLine() ?? "0");
// Обьявляю массив array
char[] array;
// Перевожу введеное число в строку и перевожу в символы для массива array
array = numbers.ToString().ToCharArray();
// Вывожу второй символ массива
Console.WriteLine(array[1]);