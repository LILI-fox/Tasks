//Задача 26: Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3 78 -> 2 89126 -> 5

Console.WriteLine("Insert number: ");

bool isParsed = int.TryParse(Console.ReadLine(), out int n);

if(!isParsed|| n==0)
{
    Console.WriteLine("Insert correct number!");
}    

int GetSumOfDigits(int n)
{
    int count = 0;
    for (; n != 0; count++)
    {
        n = n / 10;
    }
    return count;
}


int result = GetSumOfDigits(n);

Console.WriteLine(result);

