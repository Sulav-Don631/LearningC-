public class Country
{
    public string Name { get; set; }
    public string Continent { get; set; }
    public string Capital { get; set; }
    public long Population { get; set; }
    public DateTime IndependeceDay { get; set; }

    public Country(string n, string c, dtring cp, long p, DateTime i = default)
    {
        Name = n;
        Continent = c;
        Capital = cp;
        Population = p;
        IndependeceDay = i;
    }
    





}