// Заменим для возвращаемого числа int на double.  E + 29 означает, что получившееся число нужно умножить на 10 в 29 степени. 
// Это достаточно большие числа. Но тип double позволяет их хранить. 

double Factorial(int n)
{
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
