using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Composite.Composite;

namespace Visitor_Composite.Visitor
{
    public abstract class ComputerVisitor
    {
        public abstract void RepairCase(Case computerCase);
        public abstract void RepairCPU(CPU cpu);
        public abstract void RepairCPUSokect(CPUSocket cpuSoket);
        public abstract void RepairGPU(GPU gpu);
        public abstract void RepairMotherBoard(MotherBoard motherBoard);
    }
}
