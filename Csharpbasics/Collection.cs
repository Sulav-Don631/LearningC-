using System.Collections.Generic;
namespace LearnCollectiion
{
    public class Collections
    {
        void LearnLists()
        {
            List<byte> ages = new List<byte>();
            ages.Add(10);
            ages.Add(20);


            List<Country> countries = new List<Country>();  //Custome type
            countries.Add(new Country());
            
        }

        public void LearnDictionary()  //store key value pair note: Key should be unique
        {
             var countryPop = new Dictionary<string, int>
            {
                ["Usa"] = 2000,
                ["Nepal"]= 1232,
                ["India"] = 12334
            };

            //for printing

            foreach(var population in countryPop)
            {
                Console.WriteLine($"Country : {population.Key} , Population : {population.Value}");
            }

        }
    }

    public class Country
    {
        public string? Name { get; set; }
    }
}