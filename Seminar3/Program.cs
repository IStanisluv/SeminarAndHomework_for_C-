/* Напишите пр., которая по заданной четверти, показывпет диапозон координат точек

void ShowDiapozone(int quad)
{
    if (quad == 1) Console.WriteLine("x > 0 and y > 0");
    else if (quad == 2) Console.WriteLine("x < 0 and y > 0");
    else if (quad == 3) Console.WriteLine("x < 0 and y < 0");
    else if (quad == 4) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine("Wrong input!");
}

Console.Write("Input a number of quadrant(from 1 to 4):");
int quadrant = Convert.ToInt32(Console.ReadLine());

ShowDiapozone(quadrant);
*/

//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
 /*int ShowDiapozone(int x, int y)
 {
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y > 0) return 4;
    else  return -1;
}
 
 Console.Write("Input x ");
 int coordinate1 =Convert.ToInt32(Console.ReadLine());
 Console.Write("Input y ");
 int coordinate2 =Convert.ToInt32(Console.ReadLine());

 int result = ShowDiapozone(coordinate1, coordinate2);
 Console.WriteLine(result);
*/


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

/* double Hyp(int x1, int y1, int x2, int y2)
 {
    double result = Math.Sqrt(( x2 -x1 )*( x2 -x1 )+ ( y2-y1 )*( y2-y1 ));
    return result;
 }
Console.Write("Intput x1:");
int x1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Intput y1:");
int y1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Intput x2:");
int x2 =Convert.ToInt32(Console.ReadLine());
Console.Write("Intput y2:");
int y2 =Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Hyp(x1,y1,x2,y2));

*/
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
/*
void Pow2(int pow)
{
    int count = 1;
    while(count<=pow)
    {
        Console.WriteLine($"{count} - {count*count}");
        count++;
    }
}

Console.Write("Input number");
int pow = Convert.ToInt32(Console.ReadLine());

Pow2(pow);
*/

