// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно 
//палиндромом.
// 14212 -> нет
// 12821 -> да



// Код ниже работает, но выдает ворнинги.
Console.WriteLine ("введите пятизначное число");

// тут должна быть проверка на пятизначность.

string num_in = Console.ReadLine();
char[] num_in_array = num_in.ToCharArray();
Array.Reverse(num_in_array);
string num_out = new string(num_in_array);
if (num_in == num_out)
{Console.WriteLine ("палиндром");
}
else
{
    Console.WriteLine ("не палиндром");
}



// //разворот числа происходит. Но сравнение выдает неравентсво даже для палиндрома. 

// Console.WriteLine ("введите пятизначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// string result = "";
// int a = num % 10;
// num = num / 10;
// result += a;

// a = num % 10;
// num = num / 10;
// result += a;

// a = num % 10;
// num = num / 10;
// result += a ;

// a = num % 10;
// num = num / 10;
// result += a;

// a = num % 10;
// num = num / 10;
// result += a;

// int final;
// final = Convert.ToInt32(result);
// //выводим результат разворота
// Console.WriteLine (final);

// if (num == final)
// {Console.WriteLine ("палиндром");
// }
// else
// {
//     Console.WriteLine ("не палиндром");
// }