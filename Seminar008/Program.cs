// Task1

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
       for(int j = 0; j< columns; j++)
           newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    
    return newArray;        
}

// 2 5 1
// 3 7 4
// 9 6 8

// 2 3 9
// 5 7 6
// 1 4 8


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

int[,] Reverse2dArray(int[,] array)
{
    if(array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Number of rows and columns is not the the same!");
        return array;
    }

    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    return array;    
}

Console.Write("Input numberof rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numberof columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m,n,min,max);
// Show2dArray(myArray);
// Console.WriteLine();
// Show2dArray(Reverse2dArray(myArray));

// task 2

int[,] Cut2dArray(int[,] array)
{
    int iMin = 0, jMin = 0;

    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 1; j < array.GetLength(1); j++)
        {
            if(array[i,j] < array[iMin,jMin])
            {
                iMin = i;
                jMin = j;
            }
        }
    for(int j = 0; j < array.GetLength(1); j++)
        array[iMin, j] = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        array[i, jMin] = 0;

    return array;           
}

// int[,] myArray = CreateRandom2dArray(m,n,min,max);
// Show2dArray(myArray);
// Console.WriteLine();
// Show2dArray(Cut2dArray(myArray));

// task 3

// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и посленюю строку массива.

int[,] ChangeStrings (int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
        
        {
            var temp = array[0,i];
            array[0,i] = array[array.GetLength(1)-1,i];
            array[array.GetLength(1)-1,i] = temp;
        }
    return array;
}

int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
Console.WriteLine();
Show2dArray(ChangeStrings(myArray));



