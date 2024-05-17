// Семинар по C# №8

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




// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] MatrixChangeRows(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }
    return matrix;
}

// int rows = SetNumber("Введите количество строк:");
// int columns = SetNumber("Введите количество столбцов:");

// int min = SetNumber("Введите min:");
// int max = SetNumber("Введите max:");
// Console.WriteLine();

// int[,] matrix = GetMatrix(rows, columns, min, max);
// PrintMatrix(matrix);

// Console.WriteLine();
// Console.WriteLine();

// matrix = MatrixChangeRows(matrix);
// PrintMatrix(matrix);



// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

int[,] MatrixChangeRC(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i, j] = matrix[j, i];
        }
        Console.WriteLine();
    }
    return result;
}

// int rows = SetNumber("Введите размерность матрицы:");

// int min = SetNumber("Введите min:");
// int max = SetNumber("Введите max:");
// Console.WriteLine();

// int[,] matrix = GetMatrix(rows, rows, min, max);
// PrintMatrix(matrix);

// Console.WriteLine();
// Console.WriteLine();

// matrix = MatrixChangeRC(matrix);
// PrintMatrix(matrix);



// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int FindElement(int[,] matrix, int find)
{
    int count = 0;
    foreach (var item in matrix)
    {
        if (item == find) count++;
    }
    return count;
}

void Rider(int[,] matrix)
{
    List<int> array = new List<int>();
    foreach (var item in matrix)
    {
        if (IsFindUnique(array, item))
        {
            Console.WriteLine($"{item} встречается {FindElement(matrix, item)} раз");
            array.Add(item);
        }
    }
}

bool IsFindUnique(List<int> array, int find)
{
    foreach (var item in array)
    {
        if (item == find) return false;
    }
    return true;
}

int rows = SetNumber("Введите количество строк:");
int columns = SetNumber("Введите количество столбцов:");

int min = SetNumber("Введите min:");
int max = SetNumber("Введите max:");
Console.WriteLine();

int[,] matrix = GetMatrix(rows, columns, min, max);
PrintMatrix(matrix);

Console.WriteLine();
Console.WriteLine();

Rider(matrix);


