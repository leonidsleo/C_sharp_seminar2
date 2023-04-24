//
//int x = 5; 

// if (x > 0) // просто выведит результат, функция
//while (x > 0) // заменили if на цикл
//{
//    Console.WriteLine("111");
  //  if (x == 3)
    //    continue; // возвращает к началу цикла
    //break; // останавливает цикл
    //x--;
//}
// смотрим цикл for - счетный цикл

// for (int i = 0; i < 10; i++)
//{
  //  Console.WriteLine($"{i} 111");
//}


//Console.WriteLine($"Ok");
// мат функции
// ген случ чисел

//double x = 7.76538;
//double result = Math.Abs(x);
//double result = Math.Floor(x);

//Console.WriteLine($"{result}");

for (int i = 0; i < 10; i++)
{
  Console.WriteLine($"{i} 111");
//}

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

 int x = new Random().Next(10, 100);

 int x1 = x / 10;
 int x2 = x % 10;
Console.WriteLine($"{x}");
if (x1 > x2)
   Console.WriteLine($"{x1}");
else
   Console.WriteLine($"{x2}");
