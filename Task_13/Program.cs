// Задача 22: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//  int[] array =  
// 5 -> 1, 4, 9, 16, 25. 2 -> 1,4

int InputInt()
{
    Console.Write("Введите число: ");
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Введите корректное число!");
        return -1;
    }
}

int num = InputInt();

int[] GetTableOfSquares(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = (int)Math.Pow(i+1,2);
    }
    return arr;
}


int [] table = GetTableOfSquares(num);


void PrintArray(int[] arr)
{
    for(int i=0; i<num; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}
 
 PrintArray (table);
 