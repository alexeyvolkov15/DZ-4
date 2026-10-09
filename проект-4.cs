using System;

enum Days
{
    понедельник = 1,
    вторник = 2,
    среда = 3,
    четверг = 4,
    пятница = 5, 
    суббота = 6,
    воскресенье = 7
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер задания (1 - 5):");
        int number = int.Parse(Console.ReadLine());

        switch(number)
        {





            case 1:
                Console.WriteLine("НОМЕР 1");
                Console.WriteLine("Упорядоченность последовательности");

                int [] numbers = new int[10];
                Console.WriteLine("Введите 10 чисел");
                
                for (int i = 0; i<10; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < 9; i++)
                {
                    if (numbers[i] < numbers[i+1])
                    {
                        continue;
                        Console.WriteLine("последовательность упорядочена");
                    }
                    else
                    {
                        Console.WriteLine("Пследовательность не упорядочена");
                        Console.WriteLine("Первое наршающее порядок число: " + numbers[i+1]);
                        break;
                    }
                }
                break;





            case 2:
                Console.WriteLine("НОМЕР 2");
                Console.WriteLine("Игральные карты");

                try
                {
                    Console.WriteLine("Введите порядковый номер карты (6 - 14): ");
                    int card = int.Parse(Console.ReadLine());

                    if (card > 5 && card < 11)
                    {
                      Console.WriteLine(card);  
                    }
                    else if (card == 11)
                    {
                        Console.WriteLine("Валет");
                    }
                    else if (card == 12)
                    {
                        Console.WriteLine("Дама");
                    }
                    else if (card == 13)
                    {
                        Console.WriteLine("Король");
                    }
                    else if (card == 14)
                    {
                        Console.WriteLine("Туз");
                    }
                    else
                    {
                        Console.WriteLine("Неправильное число");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Это не число");
                }
                finally
                {
                    Console.WriteLine("");
                }
                break;





            case 3:
                Console.WriteLine("НОМЕР 3");
                Console.WriteLine("Таблица");

                Console.WriteLine("Введите слово: ");
                string word = Console.ReadLine();
                string louword = word.ToLower();

                if (louword == "jabroni")
                {
                    Console.WriteLine("Patron Tequila");
                }
                else if (louword == "school counselor")
                {
                    Console.WriteLine("Anything with Alcohol");
                }
                else if (louword == "programmer")
                {
                    Console.WriteLine("Hipster Craft Bear");
                }
                else if (louword == "bike gang member")
                {
                    Console.WriteLine("Moonshine");
                }
                else if (louword == "politician")
                {
                    Console.WriteLine("Your tax dollars");
                }
                else if (louword == "rapper")
                {
                    Console.WriteLine("Cristal");
                }
                else
                {
                    Console.WriteLine("Beer");
                }

                break;





            case 4:
                Console.WriteLine("НОМЕР 4");
                Console.WriteLine("Дни недели");

                Console.WriteLine("Введите порядковый номер дня:");
                int dayNumber = int.Parse(Console.ReadLine());

                if (dayNumber > 0 && dayNumber < 8)
                {
                    Days days = (Days)dayNumber;
                    Console.WriteLine(days);
                }
                else
                {
                    Console.WriteLine("Неправильное число");
                }

                break;





            case 5:
                Console.WriteLine("НОМЕР 5");
                Console.WriteLine("Игрушки в сумке");

                Console.WriteLine("Скольок игрушек в сумке:");
                int n = int.Parse(Console.ReadLine());

                string [] toys = new string[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Введите название игрушки:");
                    toys[i] = Console.ReadLine();
                }

                int bag = 0;

                foreach (string toy in toys)
                {
                    if (toy == "Hello Kitty" || toy == "Barbie doll")
                    {
                        bag++;
                    }
                }

                Console.WriteLine("Количество кукол в сумке: " + bag);

                break;





            default:
                Console.WriteLine("Неправильное число");
                break;
        }
    }
}