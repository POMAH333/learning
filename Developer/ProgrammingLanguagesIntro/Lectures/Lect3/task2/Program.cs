﻿// Цикл for

string Method4(int count, string text) // принимает текст и колличество раз, возвращает готовую строку
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);


//Цикл в цикле. Вывод таблицы умножения на экран

for(int i =2; i <= 10; i++)
{
    for(int j =2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
