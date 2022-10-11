//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11          82 -> 10          9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

n = Math.Abs(n);
int sum_n = 0;    //число, полученное в результате сложения
while (n > 0)
{
    sum_n += n % 10;
    n = n / 10;
}


Console.Write("Сумма цифр в числе = ");
Console.WriteLine(sum_n);