using System;

class Program
{

    static int NOD(int a, int b)
    {
        while (b != 0)
        {
            int c = b;
            b = a % b;
            a = c;
        }
        return a;
    }

    static int NOD(int a, int b, int c)
    {
        return NOD(NOD(a, b), c);
    }

    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        
        Console.WriteLine(NOD(a, b));
        Console.WriteLine(NOD(a, b, c));
    }
}