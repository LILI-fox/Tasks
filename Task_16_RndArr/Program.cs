// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] arr = new int[8];
GetRandomArr(arr);
PrintArray(arr);

void GetRandomArr(int[] array)
{
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[1] = random.Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    int i = 0;
    for (; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}