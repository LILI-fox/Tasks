//Задача 26: Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3 78 -> 2 89126 -> 5

 int number = int.Parse(Console.ReadLine());

int result = GetNumberOfDigits(number);

Console.WriteLine(result);

int GetNumberOfDigits(int number)
{
    int i =0;
    for(; number>0;i++)
    {
        number/=10;
    }
    return i;
} 

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

