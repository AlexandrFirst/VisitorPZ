using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Composite.Composite;

namespace Visitor_Composite.Visitor
{
    public class ConcreteComputerVisitor : ComputerVisitor
    {
        public override void RepairCase(Case computerCase)
        {
            computerCase.CaseReparationAction();
        }

        public override void RepairCPU(CPU cpu)
        {
            cpu.RepairCPUAction();
        }

        public override void RepairCPUSokect(CPUSocket cpuSoket)
        {
            cpuSoket.RepairCpuSocketAction();
        }

        public override void RepairGPU(GPU gpu)
        {
            gpu.RepairGPUAction();
        }

        public override void RepairMotherBoard(MotherBoard motherBoard)
        {
            motherBoard.RepairMotherBoardAction();
        }
    }
}
