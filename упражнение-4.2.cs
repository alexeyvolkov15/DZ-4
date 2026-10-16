using System;

class Program
{

    static (int, int) Remix(int a, int b)
    {
        int c = a;
        a = b;
        b = c;
        return (a, b);
    }

    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        (a, b) = Remix(a, b);

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}