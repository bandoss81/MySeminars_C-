
//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму положительных элементов массива

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;    
}

int[] CreateArray(int size)
{
    int[] newArray = new int[size];


    Console.WriteLine("Creating array here:");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();    
}

int FindPositiveSum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum += array[i];
    }
    return sum;
}
/*
Console.Write("input size of array");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("input min");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max");
int max = Convert.ToInt32(Console.ReadLine());



int[] array = CreateRandomArray(size, min, max);


ShowArray(array);
int sunOfPositive = FindPositiveSum(array);
Console.WriteLine("Sum of positive elements in current");
*/

//Напишите программу замена элементов массива: положительные элементы замените на 
//соответствующие отрицательные, и наоборот.

int[] Otric(int[] array)
{
    for(int i = 0;i < array.Length; i++)
      array[i] = array[i] * - 1;

    return array;
}

Console.Write("input size of array");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("input min");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
int[] otric2 = Otric(array);
ShowArray(otric2);




//Задайте одномерный массив из 20 случайных чисел. Найдите количество элементов
//массива, значения которых лежат в отрезке [10,99].


int FindTwoDigist(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
       if(array[i] >= 10 && array[i] <= 99) count++;

    return count;   
}
/*
int size = 20;
Console.Write("input min");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.Write("Count of two-digit elem is " + FindTwoDigist(array));
*/






