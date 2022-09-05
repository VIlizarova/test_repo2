//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
//Вводим массив через консоль

int[] arr = new int[8];

for (int count = 0; count < arr.Length; count++)
    {
        Console.WriteLine("введите число");
        int dig = Convert.ToInt32(Console.ReadLine());
        arr[count] = dig;
    }

Console.WriteLine(String.Join(" ", arr));
