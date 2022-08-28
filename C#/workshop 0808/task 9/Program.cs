// Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

Random rand = new Random();
int number = new Random().Next(10,99);
Console.WriteLine (number);
int digit2 = number % 10;
int digit1 = number / 10;
if (digit1 > digit2)
{
    Console.WriteLine (digit1 + " наибольшая цифра");
}
else
{
    Console.WriteLine (digit2 + " наибольшая цифра");
}