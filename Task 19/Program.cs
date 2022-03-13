// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
using System;
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if (number < 10000 | number > 99999) 
    Console.WriteLine("Введённое число не является пятизначным");
else {bool Result = true;
    string numberString = Convert.ToString(number);
     for (int i=0; i < 2; i++){
         if (numberString.Substring(i,1) != numberString.Substring(4-i,1))
         Result = false;
         }
    if (Result == true) Console.WriteLine($"Число {number} является палиндромом");
    else Console.WriteLine($"Число {number} не является палиндромом");
}
