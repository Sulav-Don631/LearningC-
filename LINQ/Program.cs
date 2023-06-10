using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {

        static void Main()
        {
            // LINQ - Language Integrated Query

            int[] numbers = {12,23,55,123,55,123,5667,422,1235,2146};

            //Method Syntax
            var result1 = numbers.Where(num => num > 50).Select(num=>num);

            //Query expression Syntax
            var result2 = from num in numbers
                          where num>50
                          select num;

            //Restriction Where
            var result3 = from num in numbers 
                          where num > 50 && num < 200
                          select num;

            //projection - select
            var result4 = from num in numbers
                          where num % 2 == 0   
                          select num * num;

            //Ordering - orderby, orderby descending
            var result5 = from num in numbers
                          orderby num ascending
                          select num;
            
            // Partetioning-take, skip
            var result6 = numbers.Skip(5).Take(5);

            // Quantifiers - any, all, contains
            var result7 = numbers.Any(num => num % 2 == 0);  //True

            var result8 = numbers.All(num => num %2 == 0);   // False

            var result9 = numbers.Contains(25);

            //Generation- range
            var result10 = Enumerable.Range(1,1000);
            var result11 = Enumerable.Repeat("Hello World", 20);
        }

        void LearnLinqConplexTypes()
        {

            Country c1 = new Country("Nepal", "Asia", "KTM", "200000");
            Country c2 = new Country("India", "Asia", "Delhi", "23200000", DateTime.Parse("1997/11/11"));
            Country c3 = new Country("China", "Asia", "Honkkong", "4234200000",DateTime.Parse("1997/11/11"));
            Country c4 = new Country("Bhutan", "Asia", "Neol", "2012300",DateTime.Parse("2123/5/8"));
            Country c5 = new Country("Canada", "Europe", "addad", "200000",DateTime.Parse("3455/10/11"));
            Country c6 = new Country("America", "asdwq", "dfdf", "604953",DateTime.Parse("4567/12/6"));

            List<Country> countries = new List<Country> {c1,c2,c3,c4,c5,c6};

            //List all asian countries
            var result1 = from country in countries
                          where country.Continent = "Asia"
                          select country.Name;

            // List all asian countries which have never been invaded
            var result2 = from country in countries 
                          where country.IndependeceDay = default
                          select country.Name;
            
        }
    }
}