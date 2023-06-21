/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;
for (int n = num; n > 0; sum += n % 10, n /= 10) ;
{
        Console.Write($"Сумма чисел равна {sum}");
}