/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84*/
using static System.Console;
Clear();
WriteLine("Введите x, y, z координаты точки А: ");
int x1 = Convert.ToInt32(ReadLine());
int y1 = Convert.ToInt32(ReadLine());
int z1 = Convert.ToInt32(ReadLine());

WriteLine("Введите x, y, z координаты точки B: ");
int x2 = Convert.ToInt32(ReadLine());
int y2 = Convert.ToInt32(ReadLine());
int z2 = Convert.ToInt32(ReadLine());

int a = x2 - x1;
int b = y2 - y1;
int c = z2 - z1;
double result = Math.Sqrt(a * a + b * b + c * c);
WriteLine($"Отрезок равен {result:f2}");