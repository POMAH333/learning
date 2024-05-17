// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Enter num: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

if (num > 99 && num < 1000)
{
    int res = (num % 100) / 10;
    System.Console.WriteLine($"Вторая цифра числа {num} это {res}");
}
else
{
    System.Console.WriteLine("Введённое число не является трёхзначным");
}
