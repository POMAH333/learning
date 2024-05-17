// Семинар по C# №5

// Метод преобразования введённого значения в целое число

int SetNumber(string messageEnt)
{
    Console.WriteLine(messageEnt);
    int num = int.Parse(Console.ReadLine());
    return num;
}

//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

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

int arraySum(int[] arr, bool positiv)
{
    int size = arr.Length;
    int i = 0;
    int result = 0;

    if(positiv)
    {
        for(i = 0; i < size; i++)
        {
            if(arr[i]>0)
            {
                result += arr[i];
            } 
        }
    }
    else
    {
        for(i = 0; i < size; i++)
        {
            if(arr[i]<0)
            {
                result += arr[i];
            } 
        }
    }
    
    return result;
}

// int[] arrayNew = FillArray(12, -9, 9);
// PrintArray(arrayNew);
// System.Console.WriteLine();
// System.Console.WriteLine($"Сумма положительных элементов массива = {arraySum(arrayNew, true)}");
// System.Console.WriteLine($"Сумма отрицательных элементов массива = {arraySum(arrayNew, false)}");



// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

void ChangeElement(int[] arr)
{
    int size = arr.Length;
    int i = 0;
    int result = 0;

    for(i = 0; i < size; i++)
    {
        arr[i] *= -1;
    }

}

int[] arrayNew = FillArray(12, -9, 9);
PrintArray(arrayNew);
System.Console.WriteLine();
System.Console.WriteLine();
ChangeElement(arrayNew);
PrintArray(arrayNew);



// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да\

bool IsFindElement(int[] array, int find)
{
    foreach (int item in array)
    {
        if (find == item)
        {
            return true;
        }
    }
    return false;
}

// int number = SetNumber("Введите число");
// int[] array = FillArray(12, -9, 9);
// PrintArray(array);
// string str = IsFindElement(array, number) ? "Встречается число" : "Не встречается число";
// System.Console.WriteLine(str);


// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int CountElementArray(int[] array, int minDiap, int maxDiap)
{
    int count = 0;
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= minDiap && array[i] <= maxDiap) count++;
    }

    return count;
}

// int[] array = FillArray(123, 0, 1000);
// PrintArray(array);
// System.Console.WriteLine();
// System.Console.WriteLine();
// System.Console.WriteLine(CountElementArray(array, 10, 99));


