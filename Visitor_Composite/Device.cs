using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;
using Visitor_Composite.Composite;

namespace Visitor_Composite
{
    public class Device
    {
        Computer computer;

        public Computer Computer
        {
            get => default;
            set
            {
                computer = value;
            }
        }

        public void SetComputer(Computer computer)
        {
            this.computer = computer;
        }

        public void Visit()
        {
            ComputerItem rootitem = computer.GetComputerCase;

            computer.TraverseComputer(rootitem);
        }
    }
}
