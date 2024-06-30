// Сортировка массива по возрастанию

int [] arr = {1, 5, 4 , 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);
void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition = i;

        for(int j = i + 1; j < array.Length ; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
SelectionSort(arr);
PrintArray(arr);

// Сtrl+пробел - начинаете писать for - в списке выбрать for for loop
