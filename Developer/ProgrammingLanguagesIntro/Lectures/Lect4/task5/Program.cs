// Для 3 все хорошо, но попробуем числа побольше. 
// С определенного момента (с 17!) начинаются отрицательные числа - это переполнение

int Factorial(int n)
{
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine(Factorial(i));
}
