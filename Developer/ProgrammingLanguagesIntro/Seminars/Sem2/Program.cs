//

// Random rand = new Random();

// int num = rand.Next(100,1000);

// int num2 = num % 10;
// int num1 = num / 100;

// int max = num1 * 10 + num2;

// System.Console.WriteLine($"num = {num}; max = {max}");

//

// Console.WriteLine("Enter num1: ");
// string strNum1 = Console.ReadLine();
// int num1 = int.Parse(strNum1);

// Console.WriteLine("Enter num2: ");
// string strNum2 = Console.ReadLine();
// int num2 = int.Parse(strNum2);

// int ost = num1 % num2;

// if(ost == 0)
// {
//     Console.WriteLine($"число {num2} кратно числу {num1}");
// }
// else
// {
//     Console.WriteLine($"Остаток от деления числа {num1} на число {num2} равен {ost}");
// }

//

// Console.WriteLine("Enter num: ");
// string strNum = Console.ReadLine();
// int num = int.Parse(strNum);

// int ost7=num % 7;
// int ost23=num % 23;

// if(ost7 == 0 && ost23 == 0)
// {
//     Console.WriteLine($"число {num} кратно 7 и 23");
// }
// else
// {
//     Console.WriteLine($"Число {num} не кратно 7 и 23");
// }

//

Console.WriteLine("Enter num1: ");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.WriteLine("Enter num2: ");
strNum = Console.ReadLine();
int num2 = int.Parse(strNum);

int res1 = num1 * num1;
int res2 = num2 * num2;

if(res1 == num2 || res2 == num1)
{
    Console.WriteLine($"Yes");
}
else
{
    Console.WriteLine($"No");
}