// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int conStrInt(string messageEnt)
{
    Console.WriteLine(messageEnt);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int legNum(int num)
{
    int leghtNum = 1;

    for( ; num > 9; num /= 10)
    {
        leghtNum++;
    }
    return leghtNum;
}

int numSum(int num, int numL)
{
    int i = 0;
    int result = 0;

    for(i = 1; i <= numL; i++)
    {
        result += (num % 10);
        num /= 10;
    }
    return result;
}

int num = conStrInt("Введите число: ");
Console.WriteLine($"Сумма цифр числа {num} равна {numSum(num, legNum(num))}");
