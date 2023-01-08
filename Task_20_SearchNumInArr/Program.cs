// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


int[] array = GenerateArray(-9, 9, 12);

PrintArray(array);

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
    string message = string.Join(" ,", array);
    Console.WriteLine($"[{message}]");
}

Console.WriteLine("Введите ваше число: ");

int number = int.Parse(Console.ReadLine());

if (array.Contains(number))
{
    Console.WriteLine($"Данный массив содержит число {number}.");
}
else
{
    Console.WriteLine($"Данный массив не содержит число {number}.");
}

