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
                       from employee in employees // from - call var from employee.
                       where employee.Salary > 400000 // where - filtering
                       orderby employee.LastName, employee.FirstName
                       select new 
                       {
                           LastName = employee.LastName,
                           FirstName = employee.FirstName
                       };

            // How it works with functions chains
            //employees
            //.Where(emp => emp.Salary > 400000)
            //.OrderBy(emp => emp.LastName)
            //.OrderBy(emp => emp.FirstName)
            //.Select(emp => new
            //{
            //    LastName = emp.LastName,
            //    FirstName = emp.FirstName
            //});

            // How it works with static methods
            //var query = // query - переменная запрса.
            //    Enumerable.Select(
            //    Enumerable.OrderBy(
            //    Enumerable.OrderBy(
            //    Enumerable.Where(
            //    employees, emp => emp.Salary > 100000),
            //    emp => emp.LastName),
            //    emp => emp.FirstName),
            //    emp => new { LastName = emp.LastName, FirstName = emp.FirstName });

            Console.WriteLine("Best salary");

            foreach (var item in query)
                Console.WriteLine("{0} {1}", item.LastName, item.FirstName);

            // Delay.
            Console.ReadKey();
        }
    }
}
