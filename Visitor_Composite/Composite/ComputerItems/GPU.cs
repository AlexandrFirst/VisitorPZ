using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Composite.Visitor;

namespace Visitor_Composite.Composite
{
    public class GPU : ComputerItem
    {
        public GPU() : base("GPU")
        {
        }

        public override void Add(ComputerItem item)
        {
            Console.WriteLine("Can't add anuthing to gpu");
        }

        public override List<ComputerItem> GetChildren()
        {
            return new List<ComputerItem>();
        }

        public override void Remove(ComputerItem item)
        {
            Console.WriteLine("Can't add anuthing to gpu");
        }

        public override void RepairOperation(ComputerVisitor computerVisitor)
        {
            computerVisitor.RepairGPU(this);
        }

        public void RepairGPUAction() 
        {
            Console.WriteLine("Reapiring GPU");
        }
    }
}
