//Напишите программу, которая принимает на вход число (А) и
// выдаёт сумму чисел от 1 до А.
/*
int FindSum(int a)
{
    int sum = 0;

    for(int current = 1; current <= a; current++)
        sum += current; // sum = sum+carrent;

    return sum;

}

Console.Write("input number integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of number from 1 to {num} is {FindSum(num)}");
*/


// Напишите программу, которая принимает на вход число и выдаёт
// количество цифр в числе.
/*
int Digits(int num) 
{ 
    int result = 1; 
    int i = 1; 
    while(num / i > 10) 
    { 
        i = i * 10; 
        result++; 
    } 
    return result; 
} 
Console.Write("Введите число "); 
int n = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Количество цифр в числе: "); 
Console.Write(Digits(n));
*/


// Напишите программу, которая принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.

/*
int FindProizv(int a)
{
    int proizv = 1;

    for(int current = 1; current <= a; current++)
        proizv *= current; // sum = sum+carrent;

    return proizv;

}

Console.Write("input number integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"proizv of number from 1 to {num} is {FindProizv(num)}");
*/


// Напишите программу, которая принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int Degree(int a, int b) 
{ 
    int result = 1; 
    for(int i = 1; i <= b; i++) 
        result = result * a; 
    return result; 
} 
Console.Write("Введите первое число "); 
int n = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число "); 
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(Degree(n, m));

