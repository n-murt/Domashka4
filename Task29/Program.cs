// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using System;
class Program
{

    static void Main(string[] args)
    {
        Console.Write("Сколько чисел вводить: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Выводим массив: [{0}]", string.Join(", ", NCount(n))); ;
    }

    static int[] NCount(int n)
    {
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Ввидите число: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        return array;
    }

}