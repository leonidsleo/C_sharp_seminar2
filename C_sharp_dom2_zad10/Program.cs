﻿// Знакомство с языками программирования (семинары)
// Домашняя работа. Семинар2.
// Задача10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Показать вторую цифру трехзначного числа!");
int a = new Random().Next(100, 1000);
Console.WriteLine(a);
int a1 = a / 10; int a2 = a1 % 10;
Console.WriteLine($"Второй цифрой числа {a} является цифра {a2}");
Console.WriteLine("Программа завершена");