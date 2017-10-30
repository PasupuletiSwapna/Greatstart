using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_sample
{
    class Mygenericclass<T>
    {
        private T genericmembervariable;
        public Mygenericclass(T value)
        {
            genericmembervariable = value;
        }

        public T genericmethod(T genericparameter)
        {
            Console.WriteLine("Parameter type:{0},value:{1}",typeof(T).ToString(),genericparameter);
            Console.WriteLine("Return type:{0},value:{1}",typeof(T),ToString(),genericmembervariable);
            return genericmembervariable;
        }

        public T genericproperty { get; set; }
    }
}
