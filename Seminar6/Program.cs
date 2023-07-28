//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
void ReverseArray( int [] array)
{
    for ( int i = 0; i < array.Length / 2;i++)
    {
        int temp = array[i];
        array[i] = array[array.Length -1 -i];
        array[array.Length-1 - i] = temp;
    }
}
*/
/*
void ReverseArray( int [] array)
{
    for ( int i = 0, j=array.Length -1; i < j;i++, j --)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}


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

int [] myArray = CreateRandomArray(lenght, min, max);
ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);
*/

//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

/*int [] CreateArray( int size)
{
     int [] array = new int [size];
     for ( int i =0; i < array.Length;i ++)
     {
        Console.WriteLine($"Input {i+1} element");
        int element = Convert.ToInt32(Console.ReadLine());
        array[i] = element;
     }
     return array;
}
*/
/*
bool Check( int [] myArray)
{
    if (myArray[0] <(myArray[1]+myArray[2])&&
     myArray[1]<(myArray[0]+ myArray[2])&&
      myArray[2]<(myArray[0]+myArray[1]) )return true;
    else return false;
}

void ShowArray(int [] array)
{
    for ( int i = 0; i < array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}



Console.Write("Input A side:  ");
int aSide = Convert.ToInt32(Console.ReadLine());
Console.Write("Input B side: ");
int bSide = Convert.ToInt32(Console.ReadLine());
Console.Write("Input C side: ");
int cSide = Convert.ToInt32(Console.ReadLine());

int [] myArray ={ aSide, bSide, cSide};
bool result = Check(myArray);
Console.WriteLine(result);
*/
//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
/*
int [] CreateRandomArray(int size)
{
    int [] array = new int [size];
    array[0] = 0;
    array[1] = 1;
    for (int i =2;i <array.Length;i ++)
        array[i]=array[i-2] + array[i-1];
    return array;
}

void ShowArray(int [] array)
{
    for ( int i = 0; i < array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}

Console.Write("Input a size:  ");
int size = Convert.ToInt32(Console.ReadLine());

int []Febonoche = CreateRandomArray(size);
ShowArray(Febonoche);
*/

//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int [] CopyArray(int[]array1)
{
    int[] array2 = new int[array1.Length];
    for( int i = 0; i < array1.Length; i++)
        array2[i] = array1[i];
    return array2;
}

void ShowArray(int [] array)
{
    for ( int i = 0; i < array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}


int [] array1= {1, 2 ,3 ,4 ,5 ,6};

int [] array2= CopyArray(array1);
ShowArray(array2);