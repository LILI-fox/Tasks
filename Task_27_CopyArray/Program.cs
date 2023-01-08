using static Common.Helper;

// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования.

int[] initialArray = GenerateArray(-10, 10, 5);

PrintArray(initialArray);

int[] copiedArray = CopyArray(initialArray);

PrintArray(copiedArray);

int[] CopyArray(int[] initialArray)
{
    int[] newArr = new int[initialArray.Length];
    for (int i = 0; i < initialArray.Length; i++)
    {
        newArr[i] = initialArray[i];
    }
    return newArr;
}
