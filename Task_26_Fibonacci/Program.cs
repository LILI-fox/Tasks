using static Common.Helper;

// Задача 44: Не используя рекурсию, выведите первые
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3 
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите целое число: ");

int number = int.Parse(Console.ReadLine());

int[] array = GetArray(number);

Console.Write($"Число Фибоначчи для числа {number} равно: ");

PrintArray(array);

int[] GetArray(int number)
{
    int[] newArr = new int[number];
    newArr[0] = 0;
    newArr[1] = 1;
    for (int i = 2; i < newArr.Length; i++)
    {
        newArr[i] = newArr[i - 1] + newArr[i - 2];
    }
    return newArr;
}

