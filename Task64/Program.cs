/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1.

N = 5 -> "4, 2"
N = 8 -> "8, 6, 4, 2"
*/

Console.WriteLine("Введите N");
int number = Convert.ToInt32(Console.ReadLine());

EvenNumbersNTo1(number);

void EvenNumbersNTo1 (int n)
{
    if (n % 2 == 0 && n > 1)
    {
        Console.Write($"{n} ");
        EvenNumbersNTo1(n-2);
    }
    else if (n % 2 == 1 && n > 1)
    {
        EvenNumbersNTo1(n-1);
    }
}