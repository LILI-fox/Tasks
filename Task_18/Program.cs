// Задача 31 (демонстрационная): задайте массив из 12 элементов,
// заполненный случайными числами из промежутка [-9,9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных чисел равна -20.

int[] array = GenerateArray(-9, 9, 12);

PrintArray(array);

int SumPositiveNumbers = GetSumPositiveNumbersInArray(array);

int SumNegativeNumbers = GetSumNegativeNumbersInArray(array);

Console.WriteLine($"Сумма положительных чисел равна {SumPositiveNumbers},сумма отрицательных чисел равна {SumNegativeNumbers}");

int[] GenerateArray(int min, int max, int lenght)
{
    Random random = new Random();
    int[] array = new int[lenght];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

int GetSumPositiveNumbersInArray(int[] array)
{
    int SumPositiveNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0)
        {
            SumPositiveNumbers = SumPositiveNumbers + array[i];
        }
    }
    return SumPositiveNumbers;
}

int GetSumNegativeNumbersInArray(int[] array)
{
    int SumNegativeNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            SumNegativeNumbers = SumNegativeNumbers + array[i];
            // SumNegativeNumbers += array[i];
        }
    }
    return SumNegativeNumbers;
}

void PrintArray(int[] array)
{
    string message = string.Join(" ,", array);
    Console.WriteLine($"[{message}]");
}

// Console.WriteLine(@"[{0}]", string.Join(" , ", array));
// Console.WriteLine($"[{string.Join(" , ", array)}]");
// Console.WriteLine($"{array[i]}");
