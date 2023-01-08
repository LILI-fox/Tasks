
// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1 
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int[] array = GenerateArray(-100, 100, 123);

PrintArray(array);

int result = FindNumbersInArray(array, 10, 99);

Console.WriteLine($"Количество элементов массива, лежащих на отрезке [10;99], равно {result}");

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

void PrintArray(int[] array)
{
    string message = string.Join(", ", array);
    Console.WriteLine($"[{message}]");
}

int FindNumbersInArray(int[] array, int min, int max)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max)
        {
            result++;
        }
    }
    return result;
}





