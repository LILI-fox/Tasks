using static Common.Helper;

//Задача 40: Напишите программу, которая принимает на
// вход три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника:
// каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите длину стороны А: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину стороны В: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину стороны С: ");
int c = int.Parse(Console.ReadLine());

int result = GetCheckTriangle(a, b, c);

int GetCheckTriangle(int a, int b, int c)
{
    if (a < (b + c) && b < (a + c) && c < (b + a))
    {
        Console.WriteLine(true);
    }
    else
    {
        Console.WriteLine(false);
    }
    return a;
}