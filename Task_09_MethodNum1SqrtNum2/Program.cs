// 4 Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да -4, 16 -> да 25, 5 -> да 8,9 -> нет

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA == numberB)
{
    Console.WriteLine("Вы ввели одинаковые числа!");
    return;
}
if (numberA == numberB * numberB)
{
    Console.WriteLine($"Число {numberA} является квадратом числа {numberB}");
}
else
{
    if (numberB == numberA*numberA)
    {
        Console.WriteLine($"Число {numberB} является квадартом числа {numberA}");
    }
    else 
    {
        Console.WriteLine("Ни одно число не является квадратом другого");
    }
}
