using System;

enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

enum TimeOfDay
{
    Morning,
    Day,
    Evening,
    Night
}

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Введите день недели");
        DayOfWeek dayOfWeek = (DayOfWeek)Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите время дня:");
        int inputTime = int.Parse(Console.ReadLine());
        TimeOfDay timeOfDay = TimeOfDay.Night;

        if (inputTime >= 7 && inputTime <= 12)
        {
            timeOfDay = TimeOfDay.Morning;
        }
        else if (inputTime >= 13 && inputTime <= 18)
        {
            timeOfDay = TimeOfDay.Day;
        }
        else if (inputTime >= 18 && inputTime <= 23)
        {
            timeOfDay = TimeOfDay.Evening;
        }

        if (inputTime >= 0 && inputTime <= 6)
        {
            Console.WriteLine("Сейчас {0}, {1}", dayOfWeek, TimeOfDay.Night);
        }
        else
        {
            Console.WriteLine("Сейчас {0}, {1}", dayOfWeek, timeOfDay);
        }
    }
}
