using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public class SomeClass
    {
        public void ActionA() 
        {
            Console.WriteLine("Doing Action A");
        }

        public void ExtendBy(Visitor v) 
        {
            v.ExtendSomeClass(this);
        }
    }
}
