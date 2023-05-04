﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num = Math.Abs(ReadInt("Введите целое положительное число"));

for (int i=1; i<=num; i++)
{
    System.Console.WriteLine($" {Math.Pow(i,3)}");
}