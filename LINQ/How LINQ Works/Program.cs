using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_LINQ_Works
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // Data
            var employees = new List<Employee>
            {
                new Employee
                {
                    FirstName = "Armen",
                    LastName = "Sargsyan",
                    Salary = 200000,
                    StartDate = DateTime.Parse("1/4/1992")
                },
                new Employee
                {
                    FirstName = "Anna",
                    LastName = "Karapetyan",
                    Salary = 450000,
                    StartDate = DateTime.Parse("12/3/1985")
                },
                new Employee
                {
                    FirstName = "Anahit",
                    LastName = "Vardanyan",
                    Salary = 1000000,
                    StartDate = DateTime.Parse("1/12/1991")
                }
            };

            // LINQ 
            var query = // query - var 
                        employees
                        .Where(emp => emp.Salary > 100000)
                        .OrderBy(emp => emp.LastName)
                        .OrderBy(emp => emp.FirstName)
                        .Select(emp => new
                        {
                            LastName = emp.LastName,
                            FirstName = emp.FirstName
                        });

            Console.WriteLine("Best salary");

            foreach (var item in query)
                Console.WriteLine("{0} {1}", item.LastName, item.FirstName);

            // Delay.
            Console.ReadKey();
        }
    }
}
