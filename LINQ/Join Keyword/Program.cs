using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join_Keyword
{
    public class EmployeeID
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class EmployeeNationality
    {
        public string Id { get; set; }
        public string Nationality { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // Collection1
            var employees = new List<EmployeeID>
            {
                new EmployeeID {Id = "111", Name = "Tatevik Galstyan"},
                new EmployeeID {Id = "222", Name = "Ivan Ivanov"},
                new EmployeeID {Id = "333", Name = "Jhon Smith"},
                new EmployeeID {Id = "444", Name = "Anna Gevorgyan"}
            };

            // Collection2
            var empNationalities = new List<EmployeeNationality>
            {
                new EmployeeNationality {Id = "111", Nationality = "Armenian"},
                new EmployeeNationality {Id = "222", Nationality = "Ukrainian"},
                new EmployeeNationality {Id = "333", Nationality = "American"},
            };

            
            // Using join to get information from 2 collections
            var query = from emp in employees
                        join n in empNationalities
                        on emp.Id equals n.Id
                        orderby n.Nationality descending 
                        select new
                        {
                            Id = emp.Id,
                            Name = emp.Name,
                            Nationality = n.Nationality
                        };

            foreach (var person in query)
                Console.WriteLine("{0}, {1}, \t{2}", person.Id, person.Name, person.Nationality);

            // Delay.
            Console.ReadKey();
        }
    }
}
