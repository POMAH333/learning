// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1*x+b1 = k2*x+b2
// x*(k1-k2) = b2-b1
// x = (b2-b1) / (k1-k2)
// (y-b1)/k1 = (y-b2)/k2
// y*k2 - b1*k2 = y*k1 - b2*k1
// y*(k2-k1) = b1*k2 - b2*k1
// y = (b1*k2 -b2*k1) / (k2-k1)

double SetNumber(string messageEnt)
{
    Console.WriteLine(messageEnt);
    double num = double.Parse(Console.ReadLine());
    return num;
}



double b1Num = SetNumber("Задайте значение b1");
double k1Num = SetNumber("Задайте коэффициент k1");
double b2Num = SetNumber("Задайте значение b2");
double k2Num = SetNumber("Задайте коэффициент k2");
System.Console.WriteLine();
double xNum = (b2Num - b1Num) / (k1Num - k2Num);
double yNum = k1Num * xNum + b1Num;
System.Console.WriteLine($"Коордлинаты точки пересечения двух прямых: [{xNum}, {yNum}]");
