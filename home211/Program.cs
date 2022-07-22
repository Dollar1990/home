// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
 
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки А: ");
double Xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки А: ");
double Xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки А: ");
double Xc = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B: ");
double Ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B: ");
double Yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B: ");
double Yc = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((Ya-Xa),2)+ Math.Pow((Yb-Xb),2)+ Math.Pow((Yc-Xc),2) );
Console.WriteLine(distance); 
