


// Задайте думерный массив размером m x n                                                             , запролненный случайными числами.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
       for(int j = 0; j< columns; j++)
           newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    
    return newArray;        
}

void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();    
    }
}

int FindDiagSum(int[,] array)
{
    int sum = 0;

    if (array.GetLength(0) == array.GetLength(1))
        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, i];
    return sum;
}

Console.Write("Input numberof rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numberof columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);
// Console.WriteLine("Sum of main diagonal is " + FindDiagSum(myArray));

// Задайте двумерный массив. Найдитке элементы, у которых оба индекса четные,
// и замените эти элементы на их квадраты.
/* // вариант1
int[,] ArrayKvadr(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i = i + 2)
        for(int j = 0; j < array.GetLength(1); j = j + 2)
            array[i,j] *= array[i,j];

    return array;        
}

int[,] arr = CreateRandom2dArray(m,n,min,max);
Show2dArray(arr);
int[,] itog = ArrayKvadr(arr);
Console.WriteLine();
Show2dArray(itog);
*/
    // вариант2
int[,] Quad (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
       for(int j = 1; j < array.GetLength(1); j++)
           if(i % 2 == 0 && j % 2 == 0) 
             array[i,j] = array[i,j] * array[i,j];
    return array;         
}
/*
int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
Console.WriteLine();
myArray = Quad(myArray);
Show2dArray(myArray);
*/

// Задайте думерный массив размерами m на n, каждый элемент в массиве находится по формуле Aij = i + j.
// Выведите полученный рензультат на экран.

int[,] Create2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
       for(int j = 0; j< columns; j++)
           newArray[i,j] = i + j;
    
    return newArray;        
}

int[,] myArray = Create2dArray(m,n,min,max);
Show2dArray(myArray);
