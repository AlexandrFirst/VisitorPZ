using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Composite.Visitor;

namespace Visitor_Composite.Composite
{
    public abstract class ComputerItem
    {
        protected string name;
        public ComputerItem(string name)
        {
            this.name = name;
        }

        public abstract void RepairOperation(ComputerVisitor computerVisitor);
        public abstract void Add(ComputerItem item);
        public abstract void Remove(ComputerItem item);
        public abstract List<ComputerItem> GetChildren();

        public override string ToString()
        {
            return name;
        }
    }
}
