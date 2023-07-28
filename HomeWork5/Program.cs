//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int [] CreateRandomArray(int size)
{
    int [] array = new int [size];
    for(int i = 0;i < size; i++)
        array[i] = new Random().Next(100,1000);
        return array;
}

void ShowArray(int [] array)
{
    for ( int i = 0; i < array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}

int  EvenNum (int [] array)
{
    int count = 0;
    for( int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    return count;
}

Console.WriteLine("Input a lenght of array:");
int lenght = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray (lenght);
ShowArray(myArray);
int  even = EvenNum(myArray);
Console.Write("Even number in array: ");
Console.WriteLine(even);
*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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

int  SumNotEvenNumByIndex (int [] array)
{
    int sumNotEven = 0;
    for( int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) sumNotEven +=array[i] ;
    }
    return sumNotEven;
}
Console.Write("Input a lenght of array: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray (lenght, min , max);
ShowArray(myArray);
int  sumNotEvenNumByIndex = SumNotEvenNumByIndex(myArray);
Console.Write("Sum of odd numbers by  index in array: ");
Console.WriteLine(sumNotEvenNumByIndex);
*/
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
float[] CreateArray(int size)
{
    float[] array = new float[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = (float)random.NextDouble() * 10;
    }
    return array;
} 
void ShowArray(float[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

float DiffMaxMin(float[] array)
{
    float min = array[0];
    float max = array[0];

    for (int i = 0; i < array.Length; i++)
     {
        if (array[i] > max) 
            max = array[i];
        else if (array[i] < min) 
            min = array[i];
     }
    return  max - min;
}

Console.WriteLine("Input a lenght of array: ");
int Length = Convert.ToInt32(Console.ReadLine());

float[] myArray = CreateArray(Length);
ShowArray(myArray);

float result = DiffMaxMin(myArray);
Console.WriteLine("Difference max and min value in array:" + result);


