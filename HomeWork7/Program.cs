//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*

double[,] CreateDoubleArray (int rows, int columns)
{
   double[,] array = new double[rows, columns];

    Random random = new Random();
   
   for (int i = 0; i < rows; i++)
   {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = random.NextDouble() * 10 ;
            array[i,j] = Math.Round(array[i,j], 2);

        }
   }        
    return array;
}         

void Show2dArray(double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i ++)
    {
        for(int j=0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

Console.WriteLine ("Input a number of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Input a number of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine());

double[,] myArray = CreateDoubleArray(rows, columns);
Show2dArray(myArray);
*/
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int [rows, columns];
    for(int i=0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue,maxValue +1);
    return array;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i ++)
    {
        for(int j=0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void CheckInd(int[,] array)

{
    Console.WriteLine("Check by rows: ");
    int indexRows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Check by cuolumns:  ");
    int indexColumns = Convert.ToInt32(Console.ReadLine());

    if ( indexRows > array.GetLength(0) ||  indexColumns > array.GetLength(1))
    {
        Console.WriteLine("Wrong input");
        return;
    }

    Console.WriteLine(array[indexRows, indexColumns]);
}

Console.WriteLine ("Input a number of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Input a number of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Input a number of minValue: ");
int minValue = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Input a number of maxValue: ");
int maxValue = Convert.ToInt32 (Console.ReadLine());


int[,] myArray = CreateRandom2dArray  (rows, columns, minValue, maxValue);
Console.WriteLine();
Show2dArray(myArray);
Console.WriteLine();
CheckInd(myArray);
*/
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Не нашел ошибку в методе
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int [rows, columns];
    for(int i=0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue,maxValue +1);
    return array;
}

void Show2dArray(int [,] array)

{
    for(int i = 0; i < array.GetLength(0); i ++)
    {
        for(int j=0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void AvarageColumns(int [,] array)
{
    double avarage = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i=0; i < array.GetLength(0); i++)
        {
        avarage += array[j,i];
        avarage = avarage / j;
        }
    avarage = avarage / array.GetLength(1);    
    Console.WriteLine($"Avarage in {j+1} columns is {avarage}" );
    avarage = 0;
    }        
}


Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());


int[,] myArray = CreateRandom2dArray( rows, columns, minValue, maxValue);

Show2dArray(myArray);
AvarageColumns(myArray);