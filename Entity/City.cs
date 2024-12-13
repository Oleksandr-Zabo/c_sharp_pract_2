using System;

namespace c_sharp_pract_2.Entity
{
    internal class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }

        private int tel_code;
        public int Tel_code
        {
            get { return tel_code; }
            set
            {
                if (value > 0)
                {
                    tel_code = value;
                }
                else
                {
                    tel_code = 0;
                }
            }
        }

        public string[] districts = new string[] { };
        public string this[int index]
        {
            get { return districts[index]; }
            set
            {
                if (index >= 0 && index < districts.Length)
                {
                    districts[index] = value;
                }
                else if (index == districts.Length)
                {
                    Array.Resize(ref districts, districts.Length + 1);
                    districts[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
            }
        }

        public City()
        {
            Name = "Unknown";
            Country = "Unknown";
            Population = 0;
            Tel_code = 0;
        }

        public City(string name) : this()
        {
            Name = name;
        }

        public City(string name, string country) : this(name)
        {
            Country = country;
        }

        public City(string name, string country, int population) : this(name, country)
        {
            Population = population;
        }

        public City(string name, string country, int population, int tel_code) : this(name, country, population)
        {
            Tel_code = tel_code;
        }

        public City(string name, string country, int population, int tel_code, string[] dictricts) : this(name, country, population, tel_code)
        {
            districts = dictricts;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            City city = (City)obj;
            return Population == city.Population;
        }

        public static bool operator ==(City city1, City city2)
        {
            return city1.Equals(city2);
        }

        public static bool operator !=(City city1, City city2)
        {
            return !city1.Equals(city2);
        }

        public static bool operator >(City city1, City city2)
        {
            return city1.Population > city2.Population;
        }
        public static bool operator >(City city1, int population_num)
        {
            return city1.Population > population_num;
        }

        public static bool operator <(City city1, City city2)
        {
            return city1.Population < city2.Population;
        }
        public static bool operator <(City city1, int population_num)
        {
            return city1.Population < population_num;
        }



        public override string ToString()
        {
            string districts_str = "";
            foreach (var district in districts)
            {
                districts_str += district + ", ";
            }
            return $"Name: {Name}; Country: {Country}; Population: {Population}; Tel_code: {Tel_code}; Districts: {districts_str}";
        }
    }
}
