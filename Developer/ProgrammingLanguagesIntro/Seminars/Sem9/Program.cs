// Урок 9. Рекурсия

//-----------------------------------------------------------------------------------

while (true)
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Введите номер задачи:");
    Console.WriteLine("63) Задача 63.");
    Console.WriteLine("65) Задача 65.");
    Console.WriteLine("69) Задача 69.");
    Console.WriteLine("67) Задача 67.");
    Console.WriteLine();
    Console.WriteLine("0) Или введите 0 для выхода из программы");
    int menuNum = SetNumber("");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();

    switch (menuNum)
    {
        case 0: return; break;
        case 63: Task63(); break;
        case 65: Task65(); break;
        case 69: Task69(); break;
        case 67: Task67(); break;
        default: Console.WriteLine($"Задачи №{menuNum}, не существует"); break;
    }
}

//-----------------------------------------------------------------------------------

int SetNumber(string messageEnt)
{
    Console.WriteLine(messageEnt);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, columns];

    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}



// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

string StringRangeNumber(int numberN, int start = 1)
{
    if (start == numberN)
    {
        return numberN.ToString();
    }

    return $"{start}, {StringRangeNumber(numberN, start + 1)}";

}

void Task63()
{
    int number = SetNumber("Введите число:");
    Console.WriteLine();

    Console.WriteLine(StringRangeNumber(number));

    Console.WriteLine();
    Console.WriteLine();
}



// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void Task65()
{
    int numberM = SetNumber("Введите число M:");
    int numberN = SetNumber("Введите число N:");
    Console.WriteLine();

    Console.WriteLine(StringRangeNumber(numberN, numberM));

    Console.WriteLine();
    Console.WriteLine();
}



// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int DegreeAB(int number, int degree)
{
    if (degree == 0) return 1;
    return number * DegreeAB(number, degree - 1);
}

void Task69()
{
    int numA = SetNumber("Введите A:");
    int numB = SetNumber("Введите B:");
    Console.WriteLine();

    int degreeAB = DegreeAB(numA, numB);
    Console.WriteLine($"{numA} в степени {numB} = {degreeAB}");
}



// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumDigit(int number)
{
    if (number < 10) return number;
    return number % 10 + SumDigit(number / 10);
}

void Task67()
{
    int num = SetNumber("Введите число:");
    Console.WriteLine();

    int digitSum = SumDigit(num);
    Console.WriteLine($"Сумма цифр числа {num} = {digitSum}");
}


