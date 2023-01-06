// Задача 32: Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] initialArray = GenerateArray(-9, 9, 12);

int[] resultArray = GetExchangeNumbersInArray(initialArray);

PrintArray(initialArray);
PrintArray(resultArray);

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

int[] GetExchangeNumbersInArray(int[] array)
{
    int lenght = array.Length;
    int[] arr = new int[lenght];

    for (int i = 0; i < lenght; i++)
    {
        arr[i] = -array[i];
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

