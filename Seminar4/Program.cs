//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А


/*int Sum( int num)
{
    int count = 0;
    int sum = 0;
    while ( count < num)
    {
        sum += count;
        count++;
    }
    return sum;
}

Console.Write("Input number: ");
int number =Convert.ToInt32( Console.ReadLine());
Console.WriteLine(Sum(number));
*/
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

/*int Count( int number)
{
    int count = 0;
    while ( number /10 >0)
    {
        number = number / 10;
        count++;
    }
    return count + 1;
}

Console.Write("Input number: ");
int number =Convert.ToInt32( Console.ReadLine());
Console.WriteLine(Count(number));
*/
//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*int Multyply (int num)
{
    int result = 1;
    int count = 1;
    while (count < num)
    {
        result *= count;
        count++;
    }
    return result;
}

Console.Write("Input number: ");
int number =Convert.ToInt32( Console.ReadLine());
Console.Write("Factorial:");
Console.WriteLine(Multyply(number));
*/
// Методы создание массива
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

Console.Write("Input a lenght of array: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray( lenght , min , max);
ShowArray(myArray);
