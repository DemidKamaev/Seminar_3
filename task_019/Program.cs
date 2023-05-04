// Задача 19
// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


string? str = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(str![2] == str[4]);
System.Console.WriteLine(str![1] == str[5]);
