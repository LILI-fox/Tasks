using static Common.Helper;
// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101; 3 -> 11; 2 -> 10

Console.WriteLine("Введите десятичное число: ");

int number = int.Parse(Console.ReadLine());

int iteration = GetQuotients(number);

// Console.WriteLine($"Количество итераций {iteration}.");

int [] binArr = GetBin(number, iteration);

Console.Write($"Бинарное число: ");

PrintArray(binArr);

int GetQuotients(int number)
{
    int iteration = 0;
    while (number>0)
    {
        number /= 2;
        iteration += 1;
    }
    return iteration;
}

int [] GetBin(int number, int iteration)
{
    int [] array = new int [iteration];
    for (int i = array.Length -1; i >=0 ; i--)
    {
        array[i] = number % 2;
        number= number/2;
    }
    return array;
}    





