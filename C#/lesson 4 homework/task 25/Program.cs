// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите возводимое число");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень числа");

int b = Convert.ToInt32(Console.ReadLine());

int div = a; 

int count = 1;

//цикл: умножаем див на а, обновляем див, увеличиваем счетчик на 1, пока счетчик не станет равен b

for (; count < b; count++)
    {
        div = div * a;
    }

    Console.WriteLine(div);
