using static Common.Helper;

// Задача 39: Напишите программу, которая перевернет одномерный массив 
// (последний элемент будет на превом месте, а первый - на последнем и т.д.)
// [1,2,3,4,5] -> [5,4,3,2,1]; [6,7,3,6] -> [6,3,7,6]

int[] array = GenerateArray(0, 10, 5);

PrintArray(array);

int [] reversedArray = ReverseArray(array);

PrintArray(reversedArray);

int[] ReverseArray(int[] array)
{
    int [] reversedArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        reversedArray[i] = array[array.Length-1-i];
    }
    return reversedArray;
}