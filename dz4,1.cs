using System;

class Program
{
    static void Main()
    {
        int date = int.Parse(Console.ReadLine());
        if (date <= 31)
        {
            Console.WriteLine(date + " янвваря");
        }
        else if (date > 31 & date <= 59)
        {
            Console.WriteLine((date - 31) + " февраля");
        }
        else if (date > 59 & date <= 90)
        {
            Console.WriteLine((date - 59) + " марта");
        }
        else if (date > 90 & date <= 120)
        {
            Console.WriteLine((date - 90) + " апреля");
        }
        else if (date > 120 & date <= 151)
        {
            Console.WriteLine((date - 120) + " мая");
        }
        else if (date > 151 & date <= 181)
        {
            Console.WriteLine((date - 151) + " июня");
        }
        else if (date > 181 & date <= 212)
        {
            Console.WriteLine((date - 181) + " июля");
        }
        else if (date > 212 & date <= 243)
        {
            Console.WriteLine((date - 212) + " агуста");
        }
        else if (date > 243 & date <= 273)
        {
            Console.WriteLine((date - 243) + " сентября");
        }
        else if (date > 273 & date <= 304)
        {
            Console.WriteLine((date - 273) + " октября");
        }
        else if (date > 304 & date <= 334)
        {
            Console.WriteLine((date - 304) + " ноября");
        }
        else if (date > 334 & date <= 365)
        {
            Console.WriteLine((date - 334) + " декабря");
        }
    }
}