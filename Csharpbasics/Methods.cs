using System;
using EnumAndProperties;
public class MethodTeacher
{
   

    //Simple method with two arguements and a return type
    public double Sum(double firstNum, double secondNum)
    {
        return firstNum+secondNum;
    }

    // method with array of arguements and a return type
    public int SumsEvens(params int[] nums)
    {
        int sum=0;
        foreach(int num in nums)
        {
            if (num%2==0)
            {
                sum = sum + num;
            }
        }
        return sum;
    }

    //Returning multiple values - Using tuples
    // Find min and max from set of number.

    public (int , int ) FindMinMax(params int[] numbers)
    {
        int min = numbers[0]; 
        int max = numbers[0];

        foreach(int num in numbers)
        {
            if(num<min)
            {
                min = num;
            }
            if (num>max)
            {
                max = num;
            }
        }
        return (min, max);
    }

    // Named Arguments
    internal void CustomerDetails( string name, byte age, string adress)
    {
        Console.WriteLine($"Name: {name}[{age}], address: {adress}");
    }
}

public class MethodLearner
{
    static void Main3()
    {
        MethodTeacher st = new MethodTeacher();
        int[] numbers ={1,2,3,4,5,6,7,8,9,23};
        (int Min,int Max) result = st.FindMinMax(numbers);
        Console.WriteLine($"Minimum:{result.Min} and Maximum:{result.Max}");
        // st.CustomerDetails("Sulav",20, "Gongabu");
        // named arguments
        st.CustomerDetails(age : 20, adress : "Gongabu", name : "Sulav"); // By this way we can write in any order.
        DayWeek x;
        


        
    }
}