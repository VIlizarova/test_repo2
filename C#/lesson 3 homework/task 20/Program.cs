// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
// в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine ("введите координаты первой точки через пробел");


int[] X_arr= Console.ReadLine().Split().Select(int.Parse).ToArray();
 
int Xa = X_arr[0];
int Xb = X_arr[1];
int Xc = X_arr[2];

Console.WriteLine ("введите координаты второй точки через пробел");

int[] Y_arr= Console.ReadLine().Split().Select(int.Parse).ToArray();
 
int Ya = Y_arr[0];
int Yb = Y_arr[1];
int Yc = Y_arr[2];

decimal tmp = (decimal)Math.Sqrt ((int)Math.Pow(Ya - Xa, 2) + (int)Math.Pow(Yb - Xb, 2) + (int)Math.Pow(Yc - Xc, 2));

Console.WriteLine ($"{tmp:f2}");