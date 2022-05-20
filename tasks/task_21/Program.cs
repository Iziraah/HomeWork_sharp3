// Напишите программу, которая принимает на
//вход координаты двух точек и находит расстояние между
//ними в 3D пространстве.

Console.Write("введите координаты (.)А по оси OX -> ");
int Ax = int.Parse(Console.ReadLine());
Console.Write("введите координаты (.)А по оси OY -> ");
int Ay = int.Parse(Console.ReadLine());
Console.Write("введите координаты (.)А по оси OZ -> ");
int Az = int.Parse(Console.ReadLine());
Console.Write("введите координаты (.)B по оси OX -> ");
int Bx = int.Parse(Console.ReadLine());
Console.Write("введите координаты (.)B по оси OY -> ");
int By = int.Parse(Console.ReadLine());
Console.Write("введите координаты (.)B по оси OZ -> ");
int Bz = int.Parse(Console.ReadLine());
double distance = Math.Sqrt(((Bx-Ax)*(Bx-Ax))+((By-Ay)*(By-Ay))+((Bz-Az)*(Bz-Az)));
Console.WriteLine(distance);

