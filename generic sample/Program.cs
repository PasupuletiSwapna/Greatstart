using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Mygenericclass<int> intgenericclass = new Mygenericclass<int>(10);
            intgenericclass.genericmethod(200);
        }
    }
}
