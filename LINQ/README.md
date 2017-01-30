# Useful Examples of Using LINQ  <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="150px" height="150px" /> 


1. [How LINQ Works and General Syntaxis] (https://github.com/tigranv/Useful-examples/tree/master/LINQ/How%20LINQ%20Works)

2. [Group Keyword] (https://github.com/tigranv/Useful-examples/tree/master/LINQ/Group%20Keyword)

3. [Join Keyword] (https://github.com/tigranv/Useful-examples/tree/master/LINQ/Join%20Keyword)

4. [Let Keyword] (https://github.com/tigranv/Useful-examples/tree/master/LINQ/Let%20Keyword)


```c#
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
```


> Projects written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition


