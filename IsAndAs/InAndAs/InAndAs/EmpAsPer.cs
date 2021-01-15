using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAsPer
{
    class EmpAsPer
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("EmpAsPer");

        //    //see here
        //    Employee emp = new PermanentEmployee
        //    {
        //        ID = 101,
        //        Name = "Mark"
        //    };

        //    PermanentEmployee permanentEmployee = emp as PermanentEmployee;

        //    if (permanentEmployee == null)
        //    {
        //        Console.WriteLine("permanentEmployee is NULL");
        //    }
        //    else
        //    {
        //        Console.WriteLine("permanentEmployee is not NULL");
        //    }

        //    ContractEmployee contractEmployee = emp as ContractEmployee;

        //    if (contractEmployee == null)
        //    {
        //        Console.WriteLine("contractEmployee is NULL");
        //    }
        //    else
        //    {
        //        Console.WriteLine("contractEmployee is not NULL");
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
