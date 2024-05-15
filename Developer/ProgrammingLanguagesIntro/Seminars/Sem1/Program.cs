// Принять число и выдать его квадрат

Console.WriteLine("Enter num: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

if(num > 99 && num < 1000)
{
    num = num % 10;
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("Число не трёхзначное");
}


