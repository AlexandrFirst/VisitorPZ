using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Composite.Visitor;

namespace Visitor_Composite.Composite
{
    public class CPUSocket : ComputerItem
    {
        private List<ComputerItem> cpus;

        public CPUSocket() : base("CPU soket")
        {
            cpus = new List<ComputerItem>();
        }

        public ComputerItem ComputerItem
        {
            get => default;
            set
            {
            }
        }

        public override void Add(ComputerItem item)
        {
            cpus.Add(item);
        }

        public override List<ComputerItem> GetChildren()
        {
            return cpus;
        }

        public override void Remove(ComputerItem item)
        {
            cpus.Remove(item);
        }

        public override void RepairOperation(ComputerVisitor computerVisitor)
        {
            computerVisitor.RepairCPUSokect(this);
        }

        public void RepairCpuSocketAction() {
            Console.WriteLine("Reapiring CPU Socket");
        }
    }
}
