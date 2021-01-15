using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpIsCon
{
    class EmpIsCon
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("EmpIsCon");

        //    Employee emp = new ContractEmployee
        //    {
        //        ID = 101,
        //        Name = "Mark"
        //    };

        //    // Returns true
        //    if (emp is Employee)
        //    {
        //        Console.WriteLine(emp.Name + " is Employee");
        //    }
        //    else
        //    {
        //        Console.WriteLine(emp.Name + " is not Employee");
        //    }

        //    // Returns false, as the base type cannot be converted to derived type
        //    if (emp is PermanentEmployee)
        //    {
        //        Console.WriteLine(emp.Name + " is PermanentEmployee");
        //    }
        //    else
        //    {
        //        Console.WriteLine(emp.Name + " is not PermanentEmployee");
        //    }

        //    // Returns true, as the base type cannot be converted to derived type
        //    if (emp is ContractEmployee)
        //    {
        //        Console.WriteLine(emp.Name + " is ContractEmployee");
        //    }
        //    else
        //    {
        //        Console.WriteLine(emp.Name + " is not ContractEmployee");
        //    }

        //    Console.ReadLine();
        //}
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
