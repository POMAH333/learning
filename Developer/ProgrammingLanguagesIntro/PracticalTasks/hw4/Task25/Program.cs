// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int conStrInt(string messageEnt)
{
    Console.WriteLine(messageEnt);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int Pow(int num, int rank)
{
    int numPow = num;
    for(int i = 1; i < rank; i++)
    {
        numPow *= num;
    }
    return numPow;
}

int numA = conStrInt("Введите число А:");
int numB = conStrInt("Введите число B:");

int result = Pow(numA, numB);

Console.WriteLine($"Число {numA} в степени {numB} равно {result}");
