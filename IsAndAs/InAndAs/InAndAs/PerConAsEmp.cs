using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerConAsEmp
{
    class PerConAsEmp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PerConAsEmp");

            PermanentEmployee emp1 = new PermanentEmployee
            {
                ID = 101,
                Name = "Mark"
            };

            Employee employee1 = emp1 as Employee;

            ContractEmployee emp2 = new ContractEmployee
            {
                ID = 102,
                Name = "Mary"
            };

            Employee employee2 = emp2 as Employee;

            if (employee1 == null)
            {
                Console.WriteLine("employee1 is NULL");
            }
            else
            {
                Console.WriteLine("employee is not NULL");
            }

            if (employee2 == null)
            {
                Console.WriteLine("employee2 is NULL");
            }
            else
            {
                Console.WriteLine("employee2 is not NULL");
            }

            Console.ReadLine();
        }
    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class PermanentEmployee : Employee
    {
        public int AnnualSalary { get; set; }
    }

    class ContractEmployee : Employee
    {
        public int HourlySalary { get; set; }
    }
}
