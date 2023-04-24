// Решение задач на уроке2 по навыкам программирования. Язык C#.
// Найти максимальное число из 9
// Вариант решения без массива.
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a1 = 43;
int b1 = 77;
int c1 = 12;
int a2 = 431;
int b2 = 717;
int c2 = 112;
int a3 = 4351;
int b3 = 7743;
int c3 = 1112;

int max = Max(Max(a1, b1,c1), Max(a2, b2,c2), Max(a3, b3,c3));
Console.Write("Наибольшее число: ");
Console.WriteLine(max);