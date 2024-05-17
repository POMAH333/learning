// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Enter num: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

if (num > 5 && num < 8)
{
    System.Console.WriteLine($"Введёный день недели {num} является выходным");
}
else
{
    System.Console.WriteLine($"Введёный день недели {num} не является выходным");
}