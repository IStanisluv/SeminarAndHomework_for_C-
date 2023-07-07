/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("Input first number is ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number is ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number is ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if(max<num2) 
    {
        max = num2;
    if(max<num3)
        {
        max = num3;
        Console.WriteLine($"The third number {max} is maximum ");        
        }
    
    else
    {
    Console.WriteLine($"The second number {max} is maximum ");
    }
    }
else
{
   Console.WriteLine($"The first number {max} is maximum "); 
}