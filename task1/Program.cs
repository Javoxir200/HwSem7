/*
Задача 1: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.
*/


// функция натуральные числа от M до N
class Program
{
    static void PrintNumbers(int m, int n)
    {
        if (m > n) return;
        Console.WriteLine(m);
        PrintNumbers(m + 1, n);
    }

    static void Main(string[] args)
    {
        int m = 5; // set M
        int n = 15; // set N
        PrintNumbers(m, n);
    }
}