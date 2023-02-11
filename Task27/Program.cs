// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System;
class Program
{

    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"В числе {n} сумма цифр равна - {Program.CountSum(n)}");
    }

    static int CountSum(int n)
    {
        string str = n.ToString();

        char[] chars = str.ToCharArray();
        int c = 0;
        for (int i = 0; i < str.Length; i++)
        {
            c = c + (int)Char.GetNumericValue(chars[i]);
        }
        return c;
    }

}