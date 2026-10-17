using System;
using System.Threading;

enum UrovenVorchlivosti
{
    Спокойный,
    Ворчливый,
    ОченьВорчливый
}


struct Ded
{
    public string Name;
    public UrovenVorchlivosti Level;
    public string[] Talks;
    public int Sinjaki;

    public Ded(string name, UrovenVorchlivosti level, string[] talks)
    {
        Name = name;
        Level = level;
        Talks = talks;
        Sinjaki = 0;
    }

    public int ProveritSlova(Ded ded, params string[] mat)
    {
        int fingaly = 0;

        for (int i = 0; i < ded.Talks.Length; i++)
        {
            for (int j = 0; j < mat.Length; j++)
            {
                if (ded.Talks[i].Contains(mat[j]))
                {
                    fingaly++;
                    break;
                }
            }
        }

        Sinjaki += fingaly;
        return fingaly;
    }
}



class Program
{   


    static int Sum(params int[] numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum = sum + numbers[i];
        }
        return sum;
    }



    static int Umnojenie(ref int[] numbers)
    {
        int umn = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            umn = umn * numbers[i];
        }
        return umn;
    }



    static void Srednee(int[] numbers, out double srd)
    {
        srd = (double)Sum(numbers) / numbers.Length;
    }
    static void Main()
    {
        Console.WriteLine("Введите число от 1 до 4:");
        int number = int.Parse(Console.ReadLine());

        switch(number)
        {

            case 1:

                Console.WriteLine("Задание 1");
                Console.WriteLine("Перемещение чисел местами");

                int[] numbers = new int[20];

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = i + 1;
                }

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + ", "); //просто райт чтобы выводидлось в строчку а не столбиом 
                }

                Console.WriteLine("\nВведите первое число:"); // \n потому что выводилост на одной строке с массивом 
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                int b = int.Parse(Console.ReadLine());

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == a)
                    {
                        numbers[i] = b;
                    }
                    else if (numbers[i] == b)
                    {
                        numbers[i] = a;
                    }
                }

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + ", ");
                }
                
            break;




            case 2:

                Console.WriteLine("Задание 2");
                Console.WriteLine("Сумма, произведение и среднее арифметическое чисел");

                int[] numbers2 = new int [5];

                Console.WriteLine("Введите 5 чисел:"); 

                for (int i = 0; i < numbers2.Length; i++)
                {
                    numbers2[i] = int.Parse(Console.ReadLine());
                }

                int umnojenie = Umnojenie(ref numbers2);
                double srednee;
                Srednee(numbers2, out srednee);

                Console.WriteLine("Сумма: " + Sum(numbers2));
                Console.WriteLine("Произведение: " + umnojenie);
                Console.WriteLine("Среднее арифметическое: " + srednee);  

            break;




            case 3:

                Console.WriteLine("Задание 3");
                Console.WriteLine("Написание цифр с помощью #");

                try
                {

                    Console.WriteLine("Введите число от 0 до 9 или exit/закрыть:");
                    string exchislo = Console.ReadLine();

                    if (exchislo == "exit" || exchislo == "закрыть")
                    {
                        break;
                    }

                    int chislo = int.Parse(exchislo); 

                        if (chislo >= 0 && chislo <=9)
                        {

                            switch(chislo)
                            {
                                

                                case 0:

                                Console.WriteLine(" ### ");
                                Console.WriteLine("#   #");
                                Console.WriteLine("#   #");
                                Console.WriteLine("#   #");
                                Console.WriteLine(" ### ");

                                break;


                                case 1:

                                Console.WriteLine("  #   ");
                                Console.WriteLine(" ##   ");
                                Console.WriteLine("  #   ");
                                Console.WriteLine("  #   ");
                                Console.WriteLine(" ###  ");

                                break;


                                case 2:

                                Console.WriteLine(" ### ");
                                Console.WriteLine("#   #");
                                Console.WriteLine("   # ");
                                Console.WriteLine("  #  ");
                                Console.WriteLine("#####");

                                break;


                                case 3:

                                Console.WriteLine("#### ");
                                Console.WriteLine("    #");
                                Console.WriteLine(" ### ");
                                Console.WriteLine("    #");
                                Console.WriteLine("#### ");

                                break;


                                case 4:

                                Console.WriteLine("#   #");
                                Console.WriteLine("#   #");
                                Console.WriteLine(" ####");
                                Console.WriteLine("    #");
                                Console.WriteLine("    #");

                                break;


                                case 5:

                                Console.WriteLine(" ####");
                                Console.WriteLine("#    ");
                                Console.WriteLine("#### ");
                                Console.WriteLine("    #");
                                Console.WriteLine("#### ");

                                break;


                                case 6:

                                Console.WriteLine("#### ");
                                Console.WriteLine("#    ");
                                Console.WriteLine("#### ");
                                Console.WriteLine("#   #");
                                Console.WriteLine("#### ");

                                break;


                                case 7:

                                Console.WriteLine("#### ");
                                Console.WriteLine("    #");
                                Console.WriteLine("   # ");
                                Console.WriteLine("  #  ");
                                Console.WriteLine(" #    ");

                                break;


                                case 8:

                                Console.WriteLine(" ### ");
                                Console.WriteLine("#   #");
                                Console.WriteLine(" ### ");
                                Console.WriteLine("#   #");
                                Console.WriteLine("#####");

                                break;


                                case 9:

                                Console.WriteLine(" ### ");
                                Console.WriteLine("#   #");
                                Console.WriteLine(" ####");
                                Console.WriteLine("    #");
                                Console.WriteLine(" ### ");

                                break;
                            }

                        }

                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();

                        Console.WriteLine("Ошибка. Число должно быть от 0 до 9");

                        Thread.Sleep(3000);

                        Console.ResetColor();
                        Console.Clear();


                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("Это не число!");
                }

            break;




            case 4:

                Ded[] dedy = new Ded[5];

        dedy[0] = new Ded("Иван", UrovenVorchlivosti.Спокойный,
            new string[] { "Эх", "Гад", "Ну и дела" });

        dedy[1] = new Ded("Пётр", UrovenVorchlivosti.Ворчливый,
            new string[] { "Чёрт", "Гады" });

        dedy[2] = new Ded("Семён", UrovenVorchlivosti.ОченьВорчливый,
            new string[] { "Гад", "Чёрт", "Эх", "Олух" });

        dedy[3] = new Ded("Борис", UrovenVorchlivosti.Спокойный,
            new string[] { "Прекрасно", "Ладно" });

        dedy[4] = new Ded("Григорий", UrovenVorchlivosti.ОченьВорчливый,
            new string[] { "Гады", "Гад", "Чёрт" });

        for (int i = 0; i < dedy.Length; i++)
        {
            int novyeFingaly = dedy[i].ProveritSlova(
                dedy[i], "Гад", "Чёрт");

            Console.WriteLine(
                dedy[i].Name + ": всего синяков — " + dedy[i].Sinjaki);
        }

            break;




            default:

                Console.WriteLine("Неправильное число");

            break;

        }
    }
}