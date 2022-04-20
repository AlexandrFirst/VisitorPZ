using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Composite.Visitor;

namespace Visitor_Composite.Composite
{
    public class CPU : ComputerItem
    {
        public CPU() : base("CPU")
        {
        }

        public override void Add(ComputerItem item)
        {
            Console.WriteLine("Can't add anuthing to cpu");
        }

        public override List<ComputerItem> GetChildren()
        {
            return new List<ComputerItem>();
        }

        public override void Remove(ComputerItem item)
        {
            Console.WriteLine("Can't remove anything from cpu");
        }

        public override void RepairOperation(ComputerVisitor computerVisitor)
        {
            computerVisitor.RepairCPU(this);
        }

        public void RepairCPUAction()
        {
            Console.WriteLine("Reapiring cpu");
        }
    }
}
