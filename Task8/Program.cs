/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Input number is ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
int current = 1;
while (count<num)
{
    if (current % 2 == 0)
    {
        Console.WriteLine(current + " ");
    }
    current++;
    count++;
}