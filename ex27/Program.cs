// Задача 27:
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int FindSum(int n)
{
    int res = 0;
    while (n > 0)
    {
        res = res + n % 10;
        n /= 10;
    }
    return res;
}

if (num > 0)
{
    Console.WriteLine($"Сумма цифр в числе {num} равна {FindSum(num)}");
}
else Console.WriteLine("Число должно быть положительным (-_-)");