﻿/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("Введите первое неотрицательное число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе неотрицательное число");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана чисел {n} и {m} равна {AkkermanFunction(n, m)}");

int AkkermanFunction(int n, int m)
{
    if (n == 0) return (m + 1);
    
    else if (n != 0 && m == 0) return AkkermanFunction(n - 1, 1);

    else return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
}