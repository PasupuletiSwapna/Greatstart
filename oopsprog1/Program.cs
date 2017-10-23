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
            

            var registry = new Registry();
            var added = true;
            do {
                added = AddEmployee(registry);
            } while (added);
            Console.WriteLine("=============");

            // registry.List();
            Console.WriteLine(registry);
        }
        private static bool AddEmployee(Registry registry)
        { 
            Console.Write("Name: ");
                var name = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(name))
                return false;

                  Console.Write("Salary: ");

                var salarystring = Console.ReadLine();
                int salary = 0;
                if (!int.TryParse(salarystring, out salary))
                { 
                        Console.WriteLine("salary couldnt be parsed");
                    }
                    var employee = new Employee(name);
                    employee.Salary = salary;

                    registry.Add(employee);
                    return true;


               
                
            }
    }
    }


