using System;

class Program
{

    static int Fibonachi(int n)
    {
        if (n == 1 || n == 2)
        {
            return 1;
        }
        else
        {
            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine(Fibonachi(n));
    }
}