﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

Console.WriteLine("Введите число A и B: ");
int A = Convert.ToInt32(Console.ReadLine()); 
int B = Convert.ToInt32(Console.ReadLine());
Math.Pow(A, B);
Console.WriteLine("A^B = " + Math.Pow(A, B));
