// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");

int number = Convert.ToInt32(Console.ReadLine());

int tmp = number / 10;

int digit2 = tmp % 10;

Console.WriteLine(digit2);