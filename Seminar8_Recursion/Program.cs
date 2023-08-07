// Рекусрия забирает очень много памяти, запоминает после прохождения каждого цикла
// for или while не выделяет память под каждый проход цикла

//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int num)
{
    if(num > 1) ShowNums(num - 1);
    Console.Write(num + " ");
    
}

ShowNums(5);
*/
//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int SumOfDiGits( int num)
{
    if(num !=0) return SumOfDiGits(num / 10) + num % 10;
    return 0;
}

Console.WriteLine(SumOfDiGits(1239));
*/
//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNumbers(int m, int n)
{
    if(m > n)
    {
        ShowNumbers(m - 1,n);
        Console.Write(m + " ");
    }
    else 
    {
        Console.Write(m + " ");
        if(m < n ) ShowNumbers(m + 1 , n);
    }
}
Console.Write("Input first number: ");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n= Convert.ToInt32(Console.ReadLine());

ShowNumbers(m,n);
*/

//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
double Degree(int num, int pow)
{
    if (pow > 0)
    {
        return Degree(num , pow - 1) * num;
    }
    else if (pow < 0)
    {
        return Degree(num , pow + 1) / num;
    }
    else return 1;
}

Console.Write(Degree(5,-2));
