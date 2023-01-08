// 11. Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.
// 456 -> 46 782 -> 72 918 -> 98

Random random = new Random();
int number = random.Next(1, 1000);

Console.WriteLine("Выведенное число: " + number);

int numberA = number / 100;
int numberC = number % 10;

//дополнительная задача - вывод удаленной (второй) цифры
int numberAB = number / 10;
int numberB = numberAB % 10;

Console.WriteLine(numberB);

int result = numberA*10 + numberC;

Console.WriteLine(result);