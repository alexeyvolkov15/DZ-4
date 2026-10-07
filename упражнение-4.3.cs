using System;

class Program
{
    static void Main()
    {
        int[] dateMonth = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        String[] nameMonth = {" января", " февраля", " марта", " апреля", " мая",
        " июня", "июля", " августа", " сентября", " октября", " ноября", " декабря"};

        date = int.Parse(Console.ReadLine());

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
}