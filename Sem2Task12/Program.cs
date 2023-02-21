// Задача №12
// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе
// число кратным первому. Если второе число
// некратно первому, то программа выводит остаток от
// деления. 

int fstNum = int.Parse(Console.ReadLine() ?? "0");
int scdNum = int.Parse(Console.ReadLine() ?? "0");
int rem = fstNum % scdNum;
if (rem == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно, остаток: " + rem);
}