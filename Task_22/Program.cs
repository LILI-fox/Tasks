// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве. 
// [1 2 3 4 5] -> 5 8 3; [6 7 3 6] -> 36 21

int[] array = GenerateArray(-10, 10, 5);

PrintArray(array);

int[] newArray = GetMultiInPairs(array);

PrintArray(newArray);

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

int[] GetMultiInPairs(int[] arr)
{
    int newArrayLenght = arr.Length / 2;
    if (arr.Length % 2 != 0)
    {
        newArrayLenght++;
    }
    int[] newArray = new int[newArrayLenght];

    int i;
    for (i = 0; i < newArrayLenght - 1; i++)
    {
        newArray[i] = arr[i] * arr[arr.Length - i - 1];
    }

    if (arr.Length % 2 == 0)
    {
        newArray[i] = arr[i] * arr[arr.Length - i - 1];
    }
    else
    {
        newArray[i] = arr[i];
    }
    return newArray;
}