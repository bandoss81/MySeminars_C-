
/*
void ShowArea(int quart)
{
    if(quart >= 1 && quart <= 4)
    {
        if(quart ==1) Console.WriteLine("in this quart x > 0")
    }
}


Console.Write("input number of quart: ");
int numQuart = Convert.ToInt32(Console)
*/

//1. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится
//  эта точка.
/*
int numQuart(int x, int y)
{
    int result = -1;
    if(x > 0 && y > 0) result = 1;
    if(x < 0 && y > 0) result = 2;
    if(x < 0 && y < 0) result = 3;
    if(x > 0 && y < 0) result = 4;
    return result;
}
Console.WriteLine("inter x ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("inter y ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write(numQuart(x, y));
*/

//2. Напишите программу, которая принимает на вход число (N) и выдаёт квадраты
// чисел от 1 до N.


/*
void Quad(int number)
{
    int squad;
    int counter = 1;
    while(counter <= number)
    {
        squad = counter * counter;
        
        Console.WriteLine(squad);
        counter++;
    }
}
Console.WriteLine("in number ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("result ");
Quad(number);
*/