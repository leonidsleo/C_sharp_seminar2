// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98

// int x = new Random().Next(101, 1000);
// Console.WriteLine(x);
// int x1 = x / 100;
// int x2 = x % 10;
// Console.WriteLine($"{x1}{x2}");



////////////////////////////////////////////
// Напишите программу, которая принимает 
// на вход число и проверяет, 
// кратно ли оно одновременно  7 и 23. 

// 14 -> нет  46 -> нет  161 -> да
// Console.Write("Введите число a = ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine();
// double a1 = a / 7 % 1;
// double a2 = a / 23 % 1;
// if (a1 == 0 && a2 == 0)
// {
//     Console.Write($"Число {a} - кратнo и 7 и 23;");
// }
// else Console.Write($"Число {a} - не кратно и 7 и 23;");
// Console.WriteLine();
// Console.Write("Программа завершена");



//новая задача 3.
// Напишите программу, которая будет принимать 
// на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.  
// 34, 5 -> не кратно, остаток 4  
// 16, 4 -> кратно

// Console.Write("Введите число a = ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число b = ");
// double b = Convert.ToDouble(Console.ReadLine());
// double c = b / a % 1;
// if (c == 0)
// {
//     Console.WriteLine("b кратно числу a");
// }
// else  Console.WriteLine($"b не кратно числу a, остаток {c}");
// Console.WriteLine();
// Console.WriteLine("Программа завершена");

//Второй вариант:
// Console.Write("Введите число a = ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число b = ");
// double b = Convert.ToDouble(Console.ReadLine());
// double c = b / a % 1;
// if (c > 0)
// {
//     Console.WriteLine("b не кратно числу a");
//     Console.WriteLine($", остаток {c}");
// }
// else  Console.WriteLine($"b кратно числу a");
// Console.WriteLine();
// Console.WriteLine("Программа завершена");


//НОВАЯ ЗАДАЧА 4. Решение 1.
//Напиши программу,  где вводим три числа, а 
//потом выводим сумму только положительных чисел.

// Console.Write("Введите число a = ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число b = ");
// double b = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число c = ");
// double c = Convert.ToDouble(Console.ReadLine());
// if ((a > 0) && (b > 0) && (c > 0))
// {
//     double summ = a + b + c;
//     Console.WriteLine($"Сумма положительных чисел = {summ}");
// }
// if ((a < 0) && (b > 0) && (c > 0))
// {
//     double summ = b + c;
//     Console.WriteLine($"Сумма положительных чисел = {summ}");
// }
// if ((a > 0) && (b < 0) && (c > 0))
// {
//     double summ = a + c;
//     Console.WriteLine($"Сумма положительных чисел = {summ}");
// }
// if ((a > 0) && (b > 0) && (c < 0))
// {
//     double summ = b + c;
//     Console.WriteLine($"Сумма положительных чисел = {summ}");
// }
// if ((a < 0) && (b > 0) && (c < 0))
// {
//     double summ = b;
//     Console.WriteLine($"Сумма положительных чисел = {summ}");
// }
// if ((a < 0) && (b < 0) && (c > 0))
// {
//     double summ = c;
//     Console.WriteLine($"Сумма положительных чисел = {summ}");
// }
// if ((a > 0) && (b < 0) && (c < 0))
// {
//     double summ = a;
//     Console.WriteLine($"Сумма положительных чисел = {summ}");
// }
// if ((a < 0) && (b < 0) && (c < 0))
// {
//     double summ = 0;
//     Console.WriteLine("Нет положительных чисел");
// }
// Console.Write("Программа закончена");

// Поиск решения 2: Задачи 4. 
// Console.Write("Введите число a = ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число b = ");
// double b = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число c = ");
// double c = Convert.ToDouble(Console.ReadLine());

// double a1 = a;
// if (a > 0)
// {
//     a1 = a;
// }
//     else
//     {
//       a1 = 0;
//     }

// double b1 = b;
// if (b > 0)
// {
//     b1 = b;
// }
// else
// {
//     b1 = 0;
// }

// double c1 = c;
// if (c > 0)
// {
//     c1 = c;
// }
// else
// {
//     c1 = 0;
// }
// double summ = a1 + b1 + c1;
// Console.WriteLine($"Сумма положительных чисел = {summ}");

// Решение 3. Задачи 4. Более короткая запись. 
// Console.Write("Введите число a = ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число b = ");
// double b = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число c = ");
// double c = Convert.ToDouble(Console.ReadLine());

// double a1 = a; if (a > 0);  else a1 = 0;
// double b1 = b; if (b > 0);  else b1 = 0;
// double c1 = c; if (c > 0);  else c1 = 0;

// double summ = a1 + b1 + c1;
// Console.WriteLine($"Сумма положительных чисел = {summ}");