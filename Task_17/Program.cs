// Задача 28: Напишите программу, которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.
//4->24 5->120

int number = int.Parse(Console.ReadLine());

int res = GetMultiOfDigits(number);
Console.WriteLine(res);

int GetMultiOfDigits(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = result * i;
    }
    return result;
}