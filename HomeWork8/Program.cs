//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

int [,]Sort2dArrayWane(int [,]array)
{
    int temp;
    for(int i = 0; i <array.GetLength(0); i ++)
        for(int j = 0; j < array.GetLength(1) -1; j++)
            for(int m = j+1; m < array.GetLength(1); m++)
            {
                if(array[i,j] < array[i,m]) 
                {
                    temp = array[i,j];
                    array[i,j] = array[i,m];
                    array[i,m] = temp;
                }
            }
    return array;
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

Sort2dArrayWane(myArray);
Console.WriteLine();
Show2dArray(myArray);
*/
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int [] SumRows(int [,]array )
{
    int []Sum = new int [array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i ++)
    {
        int sum = 0;
        for(int j=0; j < array.GetLength(1); j++)
            sum += array[i,j];
        Sum[i] = sum;
    }
    return Sum;
}

int LeesSumRow(int []array)
{
    int lessRow = 0;
    for(int i = 0; i < array.Length; i ++)
    {
        if ( array[i]< array[lessRow]) lessRow = i + 1;
    }
    return lessRow;
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
int [] SumRow = SumRows(myArray);
int minRow = LeesSumRow(SumRow);
Console.WriteLine($"Minimal sum in {minRow} row");
*/
//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

bool CheckMultiplyMatrix(int [,]array1, int [,]array2)
{
    if(array1.GetLength(1) == array2.GetLength(0)) return  true;
    else return false;
}

int [,] MultiplyMatrix(int [,]array1, int [,]array2)
{
    int [,]multiplyMatrix = new int [array1.GetLength(1), array2.GetLength(0)]; 
    for(int i = 0; i < array2.GetLength(0); i ++)
    {
        for(int j=0; j < array1.GetLength(1); j++)
        {
            int sum = 0;
            for(int k=0; k < array1.GetLength(0); k++)
            {
                sum += array1[i,k] * array2[k,j];
                multiplyMatrix[i,j] = sum;
            }
            multiplyMatrix[i,j] = sum;
        }
    }
    return multiplyMatrix;
}



Console.Write("Input a number of rows in first matrix: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns in first matrix: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value in first matrix: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value in first matrix: ");
int maxValue = Convert.ToInt32(Console.ReadLine());


int[,] myArray1 = CreateRandom2dArray( rows, columns, minValue, maxValue);



Console.Write("Input a number of rows in second matrix: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns in second matrix: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible in second matrix: ");
int minValue2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value in second matrix: ");
int maxValue2 = Convert.ToInt32(Console.ReadLine());


int[,] myArray2 = CreateRandom2dArray( rows2, columns2, minValue2, maxValue2);

Show2dArray(myArray1);
Console.WriteLine();
Show2dArray(myArray2);
Console.WriteLine();

bool check = CheckMultiplyMatrix(myArray1,myArray2);
if(check == true)
{
    int [,] multiplyMatrix = MultiplyMatrix(myArray1,myArray2);
    Console.WriteLine("Multiply of 2 matrix");
    Show2dArray(multiplyMatrix);
}
else Console.WriteLine("Worng input");
*/
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.Массив размером 2 x 2 x 2


int[,,] CreateRandom3dArray(int rows, int columns, int layer)
{
    int minValue = 10;
    int maxValue = 99;
    int [,,] array = new int [rows, columns,layer];
    for(int i=0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            for(int k = 0; k < layer; k++)
            {
            array[i,j,k] = new Random().Next(minValue,maxValue);
                    for(int m = i+ 1 ; m < rows -1; m++)
                        for(int n = j+ 1; n < columns -1; n++)
                            for(int l = k + 1; l < layer -1; l++)
                            {
                                if(array[i,j,k] == array [m,n,l])
                                {
                                array[m,n,l] = new Random().Next(minValue,maxValue);
                                }
                                else 
                                {
                                    m++;
                                    n++;
                                    l++;
                                }
                            
                            }
            
            }
    return array;
}

void Show3dArray(int [,,] array)
{
    for(int i = 0; i < array.GetLength(0); i ++)
    {
        for(int j=0; j < array.GetLength(1); j++)
            for(int k=0; k < array.GetLength(2);k++)
            Console.Write($"{array[i, j , k ]} ({i},{j},{k}) ");

        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of layer: ");
int layer = Convert.ToInt32(Console.ReadLine());



int[,,] myArray = CreateRandom3dArray( rows, columns, layer);
Show3dArray(myArray);

