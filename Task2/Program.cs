/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт большее число.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Input first number is ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number is ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if(max<num2)
{
    max = num2;
    Console.WriteLine($"The second number {max} is maximum ");
}
else
{
   Console.WriteLine($"The first number {max} is maximum "); 
}

