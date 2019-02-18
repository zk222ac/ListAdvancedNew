using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ListAdvancedNew
{
   public class Employee : IComparer<Employee>
    {
        // Get properties values 
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }

        public SortingEmployes SortingEmployes1;

        public Employee(string name, int salary, int age )
        {
            // setting values
            Name = name;
            Salary = salary;
            Age = age;
            
        }

        public Employee(SortingEmployes st)
        {
            SortingEmployes1 = st;
        }

        public int Compare(Employee x, Employee y)
        {
            int result = 0;
            SortingEmployes sort = SortingEmployes1;
            if (sort == SortingEmployes.SortByAge)
            {
                if (x != null && y != null)
                {
                    result = x.Age.CompareTo(y.Age);
                }
            }
            else if (sort == SortingEmployes.SortByName)
            {
                if (x != null && y != null)
                {
                    result = String.Compare(x.Name, y.Name, StringComparison.Ordinal);
                }
            }
            else
            {
                if (sort == SortingEmployes.SortBySalary)
                {
                    if (x != null && y != null)
                    {
                        result = x.Salary.CompareTo(y.Salary);
                    }
                }
            }

            return result;

        }

        public override string ToString()
        {
            return $"Name:{Name}, Salary: {Salary} , Age: {Age}";
        }

       public enum SortingEmployes
        {
            SortByName,
            SortBySalary,
            SortByAge

        }
    }
}
