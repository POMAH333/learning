// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int SetNumber(string messageEnt)
{
    Console.WriteLine(messageEnt);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] InArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    int i = 0;
    System.Console.Write("[");
    for (i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}");
        if (i != array.Length - 1) System.Console.Write(", ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

int ArrayPositivNumCount(int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result++;
    }

    return result;
}



int size = SetNumber("Задайте количество элементов");
System.Console.WriteLine();
System.Console.WriteLine($"Введите числа:");
int[] arrayNum = InArray(size);
System.Console.WriteLine();
PrintArray(arrayNum);
System.Console.WriteLine();
int positivNum = ArrayPositivNumCount(arrayNum);
System.Console.WriteLine();
System.Console.WriteLine($"Количество положительных введённых чисел = {positivNum}");
