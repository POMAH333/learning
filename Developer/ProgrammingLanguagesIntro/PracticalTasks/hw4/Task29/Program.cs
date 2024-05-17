// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int conStrInt(string messageEnt)
{
    Console.WriteLine(messageEnt);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] FillArray(int size)
{
    int[] array = new int[size];
    int i = 0;
    
    for (i = 0; i < size; i++)
    {
        array[i] = conStrInt($"Введите {i}-ый элемент массива: ");
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
        if (i != array.Length - 1) System.Console.Write(", ");
    }
    System.Console.Write("]");
}

PrintArray(FillArray(8));
