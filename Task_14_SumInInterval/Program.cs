// Задача 24.Напишите программу, которая принимает на вход число (А)
// и выдает сумму чисел от 1 до А.
// 7 ->28, 4 ->10, 8 ->36

bool isParsed = int.TryParse(Console.ReadLine(), out int number);
Console.WriteLine(isParsed);

if (!isParsed || number < 1)
{
    Console.WriteLine("Incorrect number");
    return;
}
int sum = GetSumOfNumberInINterval(number);

Console.WriteLine(sum);

int GetSumOfNumberInINterval(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

//testing
/*
int[] numbers = new int[] { 1, 2, 3, 4 };
int[] sums = new int[] { 1, 3, 6, 10 };

for (var i=0; i<number.Lenght; i++)
{
    int sum = GetSumOfNumberInINterval(number[i]);
    if(sum!=sum[i])
    {
        Console.WriteLine($"Ожидали получить{sum[i]}, а получили{sum}");
    }
    else
    {
        Console.WriteLine("okay");
    }
}*/