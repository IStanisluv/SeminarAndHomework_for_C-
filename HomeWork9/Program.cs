//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNums(num - 1);

    
}

Console.Write("Input number: ");
int num =Convert.ToInt32(Console.ReadLine());
ShowNums(num);
*/

//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNum(int num1, int num2)
{
    if(num1 < num2)
    {
        return SumNum(num1 + 1,num2) + num1;
    }
    else if (num1 > num2)
    {
        return SumNum(num1, num2 + 1) + num2;
    }
    else if (num1 == num2) return num1;
    return 0;
}

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNum(num1, num2));
*/

//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Akkerman (int num1, int num2)
{
    if (num1 == 0)
        return num2 + 1;
    else
        if (num1 != 0 && num2 == 0)
            return Akkerman(num1 - 1, 1);
    else
      return Akkerman(num1 - 1, Akkerman(num1, num2 - 1));
}


Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Akkerman(num1, num2));
*/