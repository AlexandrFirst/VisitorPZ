using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public class Visitor
    {
        public void ExtendSomeClass(SomeClass someClass) 
        {
            Console.WriteLine("Douing Action B");
        }
    }
}
