using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAdvancedNew
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee("John Doe" , 5000 , 66 ),
                new Employee("Jane smith" , 7000 , 22 ),
                new Employee("Nick slick" , 8000 , 11),
                new Employee("Mildred Mintz" , 9000 ,44)
            };

            foreach (var emp in employees)
            {
                Console.WriteLine($"Name:{emp.Name}, Salary:{emp.Salary},Age:{emp.Age}");
            }

            Console.WriteLine(" After Sorting by Name ...................");
            
            employees.Sort(new Employee(Employee.SortingEmployes.SortByName));

            foreach (var emp in employees)
            {
                Console.WriteLine($"Name:{emp.Name}, Salary:{emp.Salary},Age:{emp.Age}");
            }
            Console.WriteLine(" After Sorting by Age ...................");

            employees.Sort(new Employee(Employee.SortingEmployes.SortByAge));

            foreach (var emp in employees)
            {
                Console.WriteLine($"Name:{emp.Name}, Salary:{emp.Salary},Age:{emp.Age}");
            }
            Console.WriteLine(" After Sorting by Salary  ...................");

            employees.Sort(new Employee(Employee.SortingEmployes.SortBySalary));

            foreach (var emp in employees)
            {
                Console.WriteLine($"Name:{emp.Name}, Salary:{emp.Salary},Age:{emp.Age}");
            }
            //// retrieve only One object
            //Employee empStartWithJ = employees.Find(x => x.Name.StartsWith("J"));
            //Console.WriteLine($"Display the Name whose match or start with  J : {empStartWithJ.Name}");

            //// retrieve multiple object
            //Console.WriteLine($"Display the Name of all employees whose name is match or start with  J : {empStartWithJ.Name}");

            //var allEmpStartWithJ = employees.FindAll(x => x.Name.StartsWith("J"));

            //foreach (var iEmployee in allEmpStartWithJ)
            //{
            //    Console.WriteLine(iEmployee);
            //}


            Console.ReadKey();

            
        }
    }
}
