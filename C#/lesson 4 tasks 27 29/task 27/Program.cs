// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");

int num = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[num.ToString().Length];
    for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = num % 10;
            num /= 10;
        }

int sum = arr.Sum();

Console.WriteLine(sum);