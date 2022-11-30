/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите меньшее число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите большее число");
int number2 = Convert.ToInt32(Console.ReadLine());
int sum = 0;

Console.WriteLine($"Сумма чисел в промежутке от {number1} до {number2} равна {IntervalSumAToB(number1, number2, sum)}");


int IntervalSumAToB (int a, int b, int sum)
{
    if (a <=b)
    {
        sum = sum + a;
        a++;
        return IntervalSumAToB(a, b, sum);
    }
    return sum;
}