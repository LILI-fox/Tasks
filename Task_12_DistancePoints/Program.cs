// Задача 21: Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату Х первой точки: ");
bool isParsedXA = int.TryParse(Console.ReadLine(), out int xa);

/* if (!isParsedXA)
{
    Console.WriteLine("Координаты ввели не корректно");
    return;
} */
Console.WriteLine("Введите координату Y первой точки: ");
bool isParsedYA = int.TryParse(Console.ReadLine(), out int ya);
if (!isParsedYA)
{
    Console.WriteLine("Координаты ввели не корректно");
    return;
}
Console.WriteLine("Введите координату Х второй точки: ");
bool isParsedXB = int.TryParse(Console.ReadLine(), out int xb);
if (!isParsedXB)
{
    Console.WriteLine("Координаты ввели не корректно");
    return;
}
Console.WriteLine("Введите координату Y второй точки: ");
bool isParsedYB = int.TryParse(Console.ReadLine(), out int yb);
if (!isParsedYB)
{
    Console.WriteLine("Координаты ввели не корректно");
    return;
}

double GetDistanceBetweenTwoPoints(double xa, double ya, double xb, double yb)

{
    double ab = Math.Sqrt((xb - xa) * (xb - xa) - (yb - ya) * (yb - ya));
    return ab;
}
double res = GetDistanceBetweenTwoPoints(xa, ya, xb, yb);

Console.WriteLine(res);