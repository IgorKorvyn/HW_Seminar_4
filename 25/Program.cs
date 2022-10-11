// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)              2, 4 -> 16

Console.Clear();
Console.Write("Введите число A  : ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень B: ");
int n = Convert.ToInt32(Console.ReadLine());
int num_n = num;    //число, возведенное в степень
for(int i = 1; i < n; i++) {
   num_n = num_n * num;
  }
Console.Write("число A в степени B = ");
Console.WriteLine(num_n);