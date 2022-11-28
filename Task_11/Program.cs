/*
Задача 18: Напишите программу, которая по заданному номеру 
четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/
Console.WriteLine("Введите номер четверти");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed)
{
    Console.WriteLine("Номер четверти ввели не корректно");
    return;
}

GetCoordinatesByQuarterNumber(number);

void GetCoordinatesByQuarterNumber(int number)
{
    if (number == 1)
    {
        Console.WriteLine("x > 0 && y > 0");
        return;
    }

    if (number == 2)
    {
        Console.WriteLine("x < 0 && y > 0");
        return;
    }

    if (number == 3)
    {
        Console.WriteLine("x < 0 && y < 0");
        return;
    }

    if (number == 4)
    {
        Console.WriteLine("x > 0 && y < 0");
        return;
    }
}
