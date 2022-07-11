//Напишите программу, которая перевернёт одномерный массив (последний элемент будет 
//на первом месте, а первый - на последнем и т.д.)

/*
int[] ReverseArray(int[] array)
{
    int lastIndex = array.Length - 1;
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    // int i = 0, j = array.Length-1;

    // while(i < j)
    // {
    //     int temp = array[i];
    //     array[i] = array[j];
    //     array[j] = temp;

    //     i++;
    //     j--;
    // }
    return array;
}

int[] myArray = {3, 5, 1, 8, 2, 9, 4};
myArray = ReverseArray(myArray);

for(int i = 0; i < myArray.Length; i++)
   Console.Write(myArray[i] + " ");
*/
// 321467
// 012345

//  18 / 2 -> 9 0
//  9 / 2 -> 4 1
// 4 / 2-> 2 0
// 2 / 2 -> 1 0
// 1 / 0 -> 0 1

// 18 -> 10010

string ChangeDigitSistem(int num)
{
    string resultNumber = string.Empty;

    while(num > 0)
    {
        resultNumber = num % 2 + resultNumber;
        num /= 2; // то же самое, что и num = num /2;
    }
    return resultNumber;
}

Console.WriteLine(ChangeDigitSistem(18));

//a < b + c

//Напишите программу, которая принимает на вход три числа и проверяет, может
// ли существовать треугольник с сторонами такой длины.

void Triangle (int a, int b, int c)
{


}

bool Triangle(int a)

// 0 1 1 2 3 5 8 13 21 34 55 ...

//
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два
// числа Фибоначчи: 0 и 1.

int[] Fibonacci(int n)
{
    int[] newArray = new int[n];
}







