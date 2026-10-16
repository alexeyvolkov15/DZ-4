using System;

class Program
{

    static bool Factorial(int n, out int result)
    {
        result = 1;
        try
        {
            checked
            {
                for (int i = 1; i <= n; i++)
                {
                    result = result * i;
                }
            }
        }
        catch (OverflowException)
        {
            result = 0;
            return false;
        }

        return true;
    }


    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (Factorial(n, out int result ))
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Переполнение");
        }
    }
}