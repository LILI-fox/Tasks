// Напишите программу, которая принимает на вход координаты точки (x,y),
//причем x /=, y/=0 и выдает номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координату х");
bool isParsedX = int.TryParse(Console.ReadLine(), out int x);
Console.WriteLine("Введите координату y");
bool isParsedY = int.TryParse(Console.ReadLine(), out int y);

if (!isParsedX || !isParsedY)
{
    Console.WriteLine("Координаты ввели некорректно");
    return;
}

//возвращаемый тип данных НазваниеМетода()
//{ тело метода
//    return 1; оператор возвращает из метода значение и останавливает его
//}

int quarterNumber = GetQuarterNumberByCoordinates(x, y);
if(quarterNumber == -1)
{
    Console.WriteLine("Координаты равны нулю");
}

Console.WriteLine($"Номер четверти: {quarterNumber} ");

//получит номер четверти по координатам - метод
int GetQuarterNumberByCoordinates(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    if (x > 0 && y < 0)
    {
        return 4;
    }
    return-1;
}