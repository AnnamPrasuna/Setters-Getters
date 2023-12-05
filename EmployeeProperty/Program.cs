using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(90,"prasuna",900000.0,"sales");
            int id=e1.Id;
            Console.WriteLine("id of the employee :" + id);
            e1.Id = 789;
            Console.WriteLine("after setting the id value:" + e1.Id);
            string name=e1.name;
            Console.WriteLine("name of the employee :"+name);
            double salary = e1.salary;
            Console.WriteLine("salary of the employee :"+salary);
            string dname = e1.dname;
            Console.WriteLine("dname of the employee :"+dname);
            Console.ReadLine();
        }
    }
}
