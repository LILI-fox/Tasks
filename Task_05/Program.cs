//9. Напишите программу, которая выводит
//случайное число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

//Random - тип данных

//int number = new Random()Next(10, 100);    - можно использовать только 1 раз

Random random = new Random();               // можно использовать несколько раз через переменную random

// Random random = new();                    - сокращенная запись
// var random = new Random();                - var сам определяет тип данных, чтоб не повторять

int number = random.Next(10, 100);           //двузначное число

Console.WriteLine(number);

int firstNumber = number / 10;               //первая цифра
int lastNumber = number % 10;                //последняя цифра   

if(firstNumber>lastNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(lastNumber);
}