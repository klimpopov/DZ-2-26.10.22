﻿/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/
double GetCoodinateDistance (int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    double distance = Math.Sqrt((Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2)));
    return distance;
}
Console.WriteLine("Введите координату X1");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y1");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z1");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X2");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y2");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z2");
int Z2 = Convert.ToInt32(Console.ReadLine());
double result = GetCoodinateDistance(X1,Y1,Z1,X2,Y2,Z2);
Console.WriteLine($"Расстояние между точками=" + result);
