//Задайте двумерный массив. Напишите программу, которая поменяет местами любые 2  строки массива.
/*
void ChangeRows(int [,]array, int row1, int row2 )
{
    if( row1 >=0 && row1 < array.GetLength(0) &&
    row2 >= 0 && row2 < array.GetLength(0) &&
    row1 != row2)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array [row2,j];
            array[row2,j] = temp;  
        }
    }
}

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

Console.Write("Input a number of first now for change: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of second now for change: ");
int r2 = Convert.ToInt32(Console.ReadLine());
ChangeRows(myArray,r1,r2);
Show2dArray(myArray);
*/
//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
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

int [,] CheckSize( int [,]array)
{
    if(array.GetLength(0) == array.GetLength(1))
    {
        for(int i = 0; i < array.GetLength(0);i++)
        {
            for(int j =1 + i; j< array.GetLength(1); j++)
            {
                int temp = array[i,j];
                array[i,j]= array[j,i];
                array[j,i]=temp;

            }
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

Console.WriteLine();

CheckSize(myArray);

Show2dArray(myArray);
*/

//Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.


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

int [] FindMin ( int [,] array)
{
    int min = array[0,0];
    int minRow = 0;
    int minCol = 0;
    for(int i = 0; i < array.GetLength(0); i ++)
    {
        for(int j=0; j < array.GetLength(1); j++)
        {
                if (array[i,j] < min) min = array[i,j];
                minRow = i;
                minCol = j;
        }
    }
    int [] minArray = {minRow,minCol};
    return minArray;
}
// Не решили
int [,] Copy(int[] minArray, int [,] array)
{
    int m = 0;
    int n = 0;
    int[,] newArray = new int [rows, columns];
    for( int i = 0; i < array.GetLength(0); i++)
    {
        if( i != minArray[0])
            for( int j =0; j < array.GetLength(1); j++)
            {
            if ( j!=minArray[1])
            {
                
            }
            }
    }
        
    return newArray;
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
