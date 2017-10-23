using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsprog1
{
    class Registry
    {

        private List<Employee> list = new List<Employee>();
        public void Add(Employee employee)
        {
            //...
            list.Add(employee);
        }
        public void List()
        {
            foreach (var employee in list)
            {
                Console.WriteLine(employee);
            }
        }
        public override string ToString()
        {
            //return base.ToString();
        
        
            
            var output = "";
            foreach (var employee in list)
            {

                output += employee + "\n";
            } 
            
            return output;
        }
    }
}
