// Семинар 3 по С#

// Метод преобразования введённого значения в целое число

int conStrInt(string messageEnt)
{
    Console.WriteLine(messageEnt);
    int num = int.Parse(Console.ReadLine());
    return num;
}



// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


// int numX = conStrInt("Введите X: ");
// int numY = conStrInt("Введите Y: ");

// if (numX != 0 && numY != 0)
// {
//     if (numX > 0)
//     {
//         if(numY > 0)
//         {
//             Console.WriteLine($"Точка с координатами {numX},{numY} находится в I четверти");
//         }
//         else
//         {
//             Console.WriteLine($"Точка с координатами {numX},{numY} находится в IV четверти");
//         }
//     }
//     else if (numY > 0)
//     {
//         Console.WriteLine($"Точка с координатами {numX},{numY} находится в II четверти");
//     }
//     else
//     {
//         Console.WriteLine($"Точка с координатами {numX},{numY} находится в III четверти");
//     }
// }
// else
// {
//     Console.WriteLine("Одна из координат равна нулю");
// }


// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


// int num = conStrInt("Введите номер четверти: ");

// if (num > 0 && num < 5)
// {
//     if (num == 1)
//     {
//         Console.WriteLine($"X > 0, Y > 0");
//     }
//     else if (num == 2)
//     {
//         Console.WriteLine($"X < 0, Y > 0");
//     }
//     else if (num == 3)
//     {
//         Console.WriteLine($"X < 0, Y < 0");
//     }
//     else
//     {
//         Console.WriteLine($"X > 0, Y < 0");
//     }
// }
// else
// {
//     Console.WriteLine("Координатной четверти с таким номером на плоскости не существует");
// }


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


// int numAx = conStrInt("Введите Ax: ");
// int numAy = conStrInt("Введите Ay: ");

// int numBx = conStrInt("Введите Bx: ");
// int numBy = conStrInt("Введите By: ");

// double numD = Math.Sqrt(Math.Pow((numAx - numBx), 2) + Math.Pow((numAy - numBy), 2));

// Console.WriteLine($"Расстояние между точками A({numAx},{numAy}) и B({numBx},{numBy}) равно: {numD}");


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


int num = conStrInt("Введите число: ");

int i = 1;

while (i <= num)
{
    Console.Write($"{Math.Pow(i, 2)}, ");
    i++;
}
