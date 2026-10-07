using System;

class Program
{
    static void Main()
    {
        int[] dateMonthVis = {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        int[] dateMonthNotVis = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        String[] nameMonth = {" января", " февраля", " марта", " апреля", " мая",
        " июня", "июля", " августа", " сентября", " октября", " ноября", " декабря"};
        
        Console.WriteLine("Ведите год:");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("Ведите день:");
        if (int.TryParse(Console.ReadLine(), out int date))
        {
            if (date >=1 & date <= 366)
            {
                if ((year % 4 == 0 & year % 100 != 0) || year % 400 == 0)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        if (date <= dateMonthVis[i])
                        {
                            Console.WriteLine(date + nameMonth[i]);
                            break;
                        }

                        date -= dateMonthVis[i];
                    }
                }
                else
                {
                    for (int i = 0; i < 12; i++)
                    {
                        if (date <= dateMonthNotVis[i])
                        {
                            Console.WriteLine(date + nameMonth[i]);
                            break;
                        }

                        date -= dateMonthNotVis[i];
                    }
                }

            } 
            else
            {
                Console.WriteLine("Неправильое число");
            }
        }
        else
        {
            Console.WriteLine("Это не число");
        }
    }
}