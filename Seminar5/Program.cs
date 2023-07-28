//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] array = new int [size];
    for(int i = 0;i < size; i++)
        array[i] = new Random().Next(minValue,maxValue + 1);
        return array;
}

void ShowArray(int [] array)
{
    for ( int i = 0; i < array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}

int GetNegativeSum( int [] array)
{
    int sum = 0;
    for( int i = 0; i < array.Length; i ++)
        if(array[i]< 0) sum +=array[i];
    return sum;
}

Console.Write("Input a lenght of array: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray (lenght, min , max);
int negativeSum = GetNegativeSum(myArray);

ShowArray(myArray);
Console.WriteLine("Sum of negatives is " + negativeSum);
*/
//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] array = new int [size];
    for(int i = 0;i < size; i++)
        array[i] = new Random().Next(minValue,maxValue + 1);
        return array;
}

void ShowArray(int [] array)
{
    for ( int i = 0; i < array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}

int[] NegativeArray( int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;
}

Console.Write("Input a lenght of array: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray (lenght, min , max);
ShowArray(myArray);
int [] negativeSum = NegativeArray(myArray);

ShowArray(myArray);
*/


