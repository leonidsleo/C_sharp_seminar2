//Знакомство с языками программирования (семинары)
// Домашняя работа. Семинар2.
// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("День недели по числу!");
Console.WriteLine();
string[] week = new string[] {"понедельник.", "вторник.", "среда.", "четверг.", "пятница.", "суббота.", "воскресенье."};
Console.Write("Введите число = ");
int a = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine();
if ((a > 0) && (a < 8)) 
{
    int b = a -1;
    Console.Write("День недели - ");
    Console.WriteLine(week[b]);
}
else 
{
    Console.WriteLine("Такого дня недели не существует!");
}
if (a == 6)
{
    Console.WriteLine("Это выходной день!");
}
if (a == 7)
{
    Console.WriteLine("Это выходной день!");
}
Console.WriteLine();
Console.Write("Программа завершена");