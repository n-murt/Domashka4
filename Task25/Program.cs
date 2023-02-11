// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using System;
class Program
{

    static void Main(string[] args)
    {
        Console.Write("Введите A: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите B: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"A в степени B - {Program.Exponentiation(a, b)}");
    }

    static int Exponentiation(int a, int b)
    {
        int c = 1;
        for (int i = 0; i < b; i++)
        {
            c = c * a;
        }
        return c;
    }

}