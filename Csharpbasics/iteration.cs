class Iteration
{
    static void Main2()  
    {
        Iteration st = new Iteration();
        st.LearnWhileLoop();
      
    }
    
    void LearnForLoop() 
    {
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Hello");
        }

        int[] num = new int[] { 3, 1 ,4 ,6 ,8};

        foreach( int x in num )
        {
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} is even");
            }
            else 
            {
                Console.WriteLine($"{x} is odd");
            }
        }
    }

    void LearnWhileLoop()
    {
        char conf = 'Y';
        while( conf == 'Y')
        {
            Console.WriteLine("hello");
            Console.WriteLine("Do yoy want to print one more time?");
            conf = Console.ReadKey().KeyChar;

        }
    }
}