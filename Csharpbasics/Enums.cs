using System;

namespace EnumAndProperties
{
enum DayWeek
{
    Sunday,
    Monday,
    Tuesday, 
    Wednesday, 
    Thursday,
    
    Friday
}
internal class Demo
{
    public DayWeek DayOfWeek { get; set; }

    void PrintGretting ()
    {
        if (DayOfWeek == DayWeek.Sunday)
        {
            Console.WriteLine("Hello");
        }
        else if (DayOfWeek == DayWeek.Friday)
        {
            Console.WriteLine("Hello again");
        }
        else
        {
            Console.WriteLine("Hey");
        }
    }
}
}