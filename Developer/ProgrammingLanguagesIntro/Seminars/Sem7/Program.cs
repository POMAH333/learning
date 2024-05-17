// Семинар по C# №7

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



// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


int[,] GetMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, columns];

    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = random.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write($"{matrix[i, l]} ");
        }
        Console.WriteLine();
    }
}

// int rows = SetNumber("Введите количество строк");
// int columns = SetNumber("Введите количество столбцов");

// int min = SetNumber("Введите min");
// int max = SetNumber("Введите max");

// int[,] matrix = GetMatrix(rows, columns, maxValue: max, minValue: min);
// PrintMatrix(matrix);



// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] GMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = i + l;
        }
    }
    return matrix;
}

// int rows = SetNumber("Введите количество строк:");
// int columns = SetNumber("Введите количество столбцов:");

// int[,] matrix = GMatrix(rows, columns);
// PrintMatrix(matrix);



// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int[,] MatrixSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            if (i % 2 == 0 && l % 2 == 0) matrix[i, l] *= matrix[i, l];
        }
    }
    return matrix;
}

int rows = SetNumber("Введите количество строк:");
int columns = SetNumber("Введите количество столбцов:");

int min = SetNumber("Введите min:");
int max = SetNumber("Введите max:");
Console.WriteLine();

int[,] matrix = GetMatrix(rows, columns, maxValue: max, minValue: min);
PrintMatrix(matrix);

Console.WriteLine();
Console.WriteLine();

matrix = MatrixSquare(matrix);
PrintMatrix(matrix);

