// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
using System;
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
int X=0;
int Y=0;
int Z=0;
if (X1>X2) X=X1-X2;
    else X=X2-X1;
if (Y1>Y2) Y=Y1-Y2;
    else Y=Y2-Y1;
if (Z1>Z2) Z=Z1-Z2;
    else Z=Z2-Z1;
double Result = Math.Sqrt((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1)+(Z2-Z1)*(Z2-Z1));
Console.WriteLine($"Расстояние между точками = {Result:f2}");