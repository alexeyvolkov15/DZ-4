using System;

class Program
{

    static int Factorial(int n)
    {
        if (n == 1 || n == 0)
        {
            return 1;
        }
        else
        {
            return (n * Factorial(n-1));
        }
    }


    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Factorial(n));
    }
}