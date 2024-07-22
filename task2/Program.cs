/*
Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
*/
class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (m > 0 && n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    static void Main(string[] args)
    {
        Console.Write("Введите число M: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = Ackermann(m, n);
        Console.WriteLine($"Ackermann({m}, {n}) = {result}");
    }
}