﻿//Знакомство с языками программирования (семинары)
// Домашняя работа. Семинар2.
// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Программа показывает третью цифру в числе int!");
Console.WriteLine();
Console.Write("Введите число = ");
long num = Convert.ToInt64(Console.ReadLine()); 
if (num < 0)
{
    num = num * -1;
}
if (num == 0)
{
    num = 1;
}
long size = (long)Math.Log10(num) + 1;  // показывает длинну числа е.
//L = L + 1;
Console.WriteLine($"Количество символов = {size};");
long cycle = 0; // счетчик цикла.
long ind = 0; // индекс массива
long value = num % 10; // значение записываемое в массив. 
long[] massif = new long[size]; // создаем массив заданной длинны, за длинну берем длинну числа num.

while (cycle < size) 
{
    massif[ind] = value;
    //Console.WriteLine(d[b]); // временно, вывод в консоль начений массива
    ind = ind + 1;
    // c = e % 10;  
    cycle = cycle + 1; 
    if (num > 0)
    {
        num = num / 10; // уменьшаем число в 10 раз
        value = num % 10; 
    }
}
if (size <= 3)
{
    Console.WriteLine("Третьего символа нет!");
}
else
{
    //Console.ReadKey(); // оператор ожидания нажатия ввода. На любителя.
    Console.WriteLine($"Третий символ = {massif[^3]};"); // знак ^ отсчитывает индекс массива с конца
}
Console.WriteLine();
Console.Write("Программа завершена!");