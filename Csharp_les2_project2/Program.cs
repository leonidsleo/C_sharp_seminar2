// Решение задач на уроке2 по навыкам программирования. Язык C#.
// Найти максимальное число из 9
// Вариант решения используя массив.
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int [] array = {32, 5, 34, 62, 8, 9, 33, 89, 1276};
//array[0] = 155; //команда присвоит индекусу 0 в массиве число 155.

int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7],array[8]));
Console.Write("Наибольшее число: ");
Console.WriteLine(max);