// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать массив
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Enter num: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

int numI = num;

if (numI > 99)
{
    while (numI > 999)
    {
        numI /= 10;
    }

    int res = numI % 10;

    System.Console.WriteLine($"Третья цифра числа {num} это {res}");
}
else
{
    System.Console.WriteLine($"Третьей цифры у числа {num} нет");
}