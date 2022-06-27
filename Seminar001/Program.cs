/* 1 задача
int num1, num2, quad;

Console.Write("Input a first number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a first number: ");
num2 = Convert.ToInt32(Console.ReadLine());

quad = num1 * num2;

if(quad == num1)
{
    Console.WriteLine("First number is a quad of second number");
}
else
{
    Console.WriteLine("First number is not a quad of second number");
}
*/




int n, current;

Console.Write("Input a number: ");
n = Convert.ToInt32(Console.ReadLine());

current = n * (-1);

while(current <= n)
{
    Console.Write(current + " ");
    current++; // current = current +1
}





