﻿// Задача 10. Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
string str = Console.ReadLine();
int number = int.Parse(str);
int first = number % 100;
int second = first / 10;
Console.WriteLine("Вторая цифра вашего числа: " + second);
