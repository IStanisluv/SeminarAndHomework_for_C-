//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*int Squerd(int num1, int num2)
{
    int res = 1;
    for( int count = 0; count < num2; count++)
    res *= num1;
return res;
}

Console.Write("Input first number: ");
int number1 =Convert.ToInt32( Console.ReadLine());
Console.Write("Input second number: ");
int number2 =Convert.ToInt32( Console.ReadLine());
Console.WriteLine(Squerd(number1,number2));
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Sum( int number)
{
    int i = 0;
    int sum = 0;
    while ( number > 0)
    {
    i = number % 10;
    number = number / 10;
    sum = sum + i;
    }
return sum;
}

Console.Write("Input number: ");
int number =Convert.ToInt32( Console.ReadLine());
Console.Write("Sum of all digits a number: ");
Console.WriteLine(Sum(number));
*/



//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран. Разработать метод CreateArray(int size), генерирующий массив на основе данных, вводимых пользователем.