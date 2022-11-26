// 3. Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23. 
// 14 -> нет 46 -> нет 161 -> да

Console.WriteLine("Введите число: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);       //проверка на введенный символ

if(!isParsed)                                               
{
    Console.WriteLine("Вы ввели не целое число!!!");
    return;
}
// или без проверки:

// int number = int.Parse(Console.ReadLine());


if (number % 7 ==0 | number % 23 == 0)
{
    Console.WriteLine($"Введенное число {number} кратно 7 и 23 одновременно.");
}
else
{
    Console.WriteLine($"Введенное число {number} НЕкратно 7 и 23 одновременно.");
}
