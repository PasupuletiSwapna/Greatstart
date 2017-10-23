using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsprog1
{
    class Program
    {



        static void Main(string[] args)
        {
            var e1 = new Employee("Sai");
            e1.Salary = 25000;

            var e2 = new Employee("Ram");
            e2.Salary = 23000;
          
            var registry = new Registry();
            registry.Add(e1);
            registry.Add(e2);
            registry.List();
        }
    }
}
