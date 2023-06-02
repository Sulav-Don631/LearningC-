using System;


class Selection 
{
    static void Main2()
    {
        Selection ss = new Selection();
        ss.LearnIfElse();

        ss.LearnSwitch();
    }
    void LearnIfElse()
    {   
        Console.Write("Enter your number");
        string i = "34";
        int x = int.Parse(i);
        if (x == 34)
        {
            Console.WriteLine("It is true");
        }
    }
    void LearnSwitch()
    {
        char opt = 's';
        switch(opt)
        {
            case 'y':
            break;

            case 's':
            Console.WriteLine("Hello");
            break;


        }

    }
}