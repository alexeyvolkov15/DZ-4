using System;

class Program
{
    static void Main()
    {
        int[] dateMonth = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        String[] nameMonth = {" января", " февраля", " марта", " апреля", " мая",
        " июня", "июля", " августа", " сентября", " октября", " ноября", " декабря"};

        if (int.TryParse(Console.ReadLine(), out int date))
        {
            if (date >=1 & date <= 365)
            {
                for (int i = 0; i < 12; i++)
                {
                    if (date <= dateMonth[i])
                    {
                        Console.WriteLine(date + nameMonth[i]);
                        break;
                    }

                    date -= dateMonth[i];
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