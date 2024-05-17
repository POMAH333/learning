// Семинар по C# №4

// Метод преобразования введённого значения в целое число

int conStrInt(string messageEnt)
{
    Console.WriteLine(messageEnt);
    int num = int.Parse(Console.ReadLine());
    return num;
}

// Подсчёт суммы чисел

int GetSum(int limit)
{
    int sum = 0;
    int i = 1;
    
    for(i = 1; i <= limit; i++)
    {
        sum += i;
    }
    return sum;
}

int legNum(int num)
{
    int leghtNum = 1;

    while (num > 9)
    {
        leghtNum++;
        num /= 10;
    }
    return leghtNum;
}

int legNumFor(int num)
{
    int leghtNum = 1;

    for( ; num > 9; num /= 10)
    {
        leghtNum++;
    }
    return leghtNum;
}

int GetComp(int limit)
{
    int comp = 1;
    int i = 1;
    
    for(i = 1; i <= limit; i++)
    {
        comp *= i;
    }
    return comp;
}

int[] FillArray(int size, int minVolume, int maxVolume)
{
    int[] array = new int[size];
    int i = 0;
    Random rand = new Random();

    for (i = 0; i < size; i++)
    {
        array[i] = rand.Next(minVolume, maxVolume + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    int i = 0;
    System.Console.Write("[");
    for(i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}");
        if (i != array.Length - 1) System.Console.Write(",");
    }
    System.Console.Write("]");
}


// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


// int numA = conStrInt("Введите число А: ");

// System.Console.WriteLine($"Sum = {GetSum(numA)}");



// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int numA = conStrInt("Введите число: ");

// System.Console.WriteLine($"Количество цифр в числе = {legNumFor(numA)}");



// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int numA = conStrInt("Введите число N: ");

// System.Console.WriteLine($"Произведение = {GetComp(numA)}");



// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

PrintArray(FillArray(8,0,1));
