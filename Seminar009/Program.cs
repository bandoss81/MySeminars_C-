// Рекурсия
// 
void ShowNums(int n)
{
    if(n > 1)
    {
        Console.Write(n + " ");
        ShowNums(n - 1);
    }
    Console.Write(n + " ");    
}

//(5) -> (4) -> (3) -> (2)  -> (1) -> (2) -> (3) -> (4) -> (5) 

int SumOfDigits(int n)
{
    if(n >= 10)
    {
        return n % 10 + SumOfDigits(n / 10);
    }
    else return n;
}

// 12345 -> 1234 -> 123 -> 12 -> 1 
// 5 + 4 + 3 + 2 + 1 = 15

// ShowNums(5);
// Console.WriteLine();
// Console.WriteLine(SumOfDigits(12345));

// Задаете значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void ShowNums2(int m, int n)
{
    if (m < n)
    {
        ShowNums2(m, n - 1);
        Console.Write(n + " ");
    }
    if (n < m)
    {
        ShowNums2(n, m - 1);
        Console.Write(m + " ");
    }
       
}   
Console.Write("Input numberof rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numberof columns: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNums2(m,n);

// Напишите программу, которая на вход принимает два числа A и B, и возводит число A в целую степень B с помощью рекурсии


int Vozvod(int a, int b)
{
    if (b > 1)
    {
        return a * Vozvod(a, b - 1);
    }
    else return a;
}

// Console.Write("Input numberof rows: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numberof columns: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Vozvod(a,b));