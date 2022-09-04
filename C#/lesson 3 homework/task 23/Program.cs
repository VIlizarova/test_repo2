// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine ("введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

int arrLenght = num + 1;
int[] array = new int[arrLenght];

for (int i=0 ; i<=num ; i++)
     {
         array[i]=i;
      }


for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
             continue;
        double doubleTMP = Math.Pow(i, 3);
        int intTMP = (int)doubleTMP;
        array[i] = intTMP;

}

array = array.Skip(1).ToArray();
var str = string.Join(", ", array);
Console.WriteLine(str);

// второй вариант вывода массива полученных значений
// for (int i = 0; i < array.Length; i++)
//     {
//         if (i == 0)
//             continue;
//         Console.WriteLine (array[i]);
//     }

