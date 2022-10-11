//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]                6, 1, 33 -> [6, 1, 33]

Console.Clear();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"\nВведите элемент массива под индексом {i}:\t ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("\nМассив из введённых чисел:\t ");
Console.WriteLine($"[{string.Join(", ", array)}]");