// Семинар по C# №6

int SetNumber(string messageEnt)
{
    Console.WriteLine(messageEnt);
    int num = int.Parse(Console.ReadLine());
    return num;
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
    for (i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}");
        if (i != array.Length - 1) System.Console.Write(", ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

int OddArraySum(int[] array)
{
    int result = 0;

    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }

    return result;
}



// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] RevertArray(int[] array)
{
    int temp = 0;

    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }

    return array;
}

// int size = SetNumber("Задайте размерность массива");
// int min = SetNumber("Задайте начало числового диапапзона");
// int max = SetNumber("Задайте конец числового диапазона");
// int[] arrayNew = FillArray(size, min, max);
// PrintArray(arrayNew);
// System.Console.WriteLine();
// int[] arrayRevert = RevertArray(arrayNew);
// PrintArray(arrayRevert);

// Console.WriteLine(string.Join(" ", array));



// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int ArrayNumberNotSum(int[] array, int NotNumber)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i != NotNumber) result += array[i];
    }

    return result;
}

bool TriangleCheck(int[] array)
{
    bool check = true;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > ArrayNumberNotSum(array, i)) check = false;
    }

    return check;
}

// int[] numbers = new int[3];
// numbers[0] = SetNumber("Введите первую сторону треугольника");
// numbers[1] = SetNumber("Введите вторую сторону треугольника");
// numbers[2] = SetNumber("Введите третью сторону треугольника");
// System.Console.WriteLine();
// System.Console.WriteLine($"Существует ли треуголиник с указанными сторонами: {TriangleCheck(numbers)}");



// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CopyArray(int[] array)
{
    int[] arrayCopy = new int[array.Length];

    for (int i = 0; i < array.Length; i++) arrayCopy[i] = array[i];

    return arrayCopy;
}

int size = SetNumber("Задайте размерность массива");
int min = SetNumber("Задайте начало числового диапапзона");
int max = SetNumber("Задайте конец числового диапазона");
int[] arrayNew = FillArray(size, min, max);
PrintArray(arrayNew);
System.Console.WriteLine();
int[] arrayCopy=CopyArray(arrayNew);
PrintArray(arrayCopy);

