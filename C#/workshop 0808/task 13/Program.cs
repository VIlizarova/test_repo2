// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("введите число");

int number = Convert.ToInt32(Console.ReadLine());

int tmp = number / 100;

//Console.WriteLine(tmp);

if (tmp == 0)
{
Console.WriteLine ("третьей цифры нет");
}

else 
{

int result = number;


    while (result > 999)
  { 
result = result / 10;
  }

       int digit3 = result % 10;
  
Console.WriteLine(digit3);
}
