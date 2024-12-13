namespace c_sharp_pract_2
{//lab ex.3
    using c_sharp_pract_2.Entity;
    internal class Program
    {
        static void Main()
        {
            var city = new Entity.City("New York", "USA", 8_500_000, 212);
            city[0] = "Manhattan";
            city[1] = "Brooklyn";
            city[2] = "Queens";
            System.Console.WriteLine(city);

            var city2 = new Entity.City("Los Angeles", "USA", 4_000_000, 213);
            city2[0] = "Hollywood";
            city2[1] = "Downtown";
            city2[2] = "Santa Monica";
            System.Console.WriteLine(city2);

            System.Console.WriteLine($"City 1 population == City 2 population: {city.Population == city2.Population}");
            System.Console.WriteLine($"City 1 population > City 2 population: {city.Population > city2.Population}");
            System.Console.WriteLine($"City 2 population < 3_000_000: {city2.Population < 3_000_000}");
        }
    }
}
