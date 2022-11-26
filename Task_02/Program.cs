// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 5 -> Пятница

int n = int.Parse(Console.ReadLine());

if (n<1 | n>=8)
{
    Console.WriteLine("Неправильно ввели число");
}
if(n==1)
{
    Console.WriteLine("Понедельник");
}
if(n==2)
{
    Console.WriteLine("Вторник");
}
if(n==3)
{
    Console.WriteLine("Среда");
}
if(n==4)
{
    Console.WriteLine("Четверг");
}
if(n==5)
{
    Console.WriteLine("Пятница");
}
if(n==6)
{
    Console.WriteLine("Суббота");
}
if(n==7)
{
    Console.WriteLine("Воскресенье");
}

