/*Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

void NToM(int m, int n)
{
  if (n > m)
  {
    System.Console.Write(m + " ");
    NToM(m + 1, n);
  }
}
NToM(m, n); */

/* Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Write(Akkerman(m, n)); */

/* Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы. */

void Reverse(int[] array, int i)
{
  if (i >= 0)
  {
    Console.Write(array[i] + " ");
    Reverse(array, i - 1);
  }
  
}

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int i = array.Length - 1;

Reverse(array, 8);