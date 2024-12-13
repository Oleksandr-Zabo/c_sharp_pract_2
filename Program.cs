namespace c_sharp_pract_2
{//lab ex- 1
    using c_sharp_pract_2.Entity;
    internal class Program
    {

        static void Main()
        {
            string[] job_description = new string[] { "Develop", "Test", "Deploy" };
            Employee employee1 = new Employee("John Doe", new DateTime(1985, 5, 15), "+123456789", "john.doe@example.com", position: "Software Developer", job_description, 100);
            Console.WriteLine(employee1);


            Employee employee2 = new Employee("Jane Doe", new DateTime(1988, 7, 25), "+987654321", "john.doe@example.com", position: "Software Developer", job_description, 50);
            Console.WriteLine(employee2);

            Console.WriteLine($"Is salary eguals: {employee1 == employee2}");
            Console.WriteLine($"Is salary 1 > 2: {employee1 > employee2}");
            Console.WriteLine($"Is salary not eguals: {employee1 != employee2}");

            employee2 += 50;

            Console.WriteLine("After employee2 += 50: ");
            Console.WriteLine(employee2);

            Console.WriteLine($"Is salary eguals: {employee1 == employee2}");
            Console.WriteLine($"Is salary 1 > 2: {employee1 > employee2}");


        }
    }
}

