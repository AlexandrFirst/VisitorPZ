using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Composite.Visitor;

namespace Visitor_Composite.Composite
{
    public class Computer
    {
        private readonly ComputerVisitor visitor;

        private ComputerItem computerCase;
        private ComputerItem motherBoard;
        private ComputerItem cpuSocket;
        private ComputerItem cpu;
        private ComputerItem gpu;

        public ComputerItem GetComputerCase
        {
            get { return computerCase; }
        }

        public ComputerItem ComputerItem
        {
            get => default;
            set
            {
            }
        }

        public Computer(ComputerVisitor visitor)
        {
            this.visitor = visitor;

            computerCase = new Case();
            motherBoard = new MotherBoard();
            cpuSocket = new CPUSocket();
            cpu = new CPU();
            gpu = new GPU();

            computerCase.Add(motherBoard);
            motherBoard.Add(cpuSocket);
            cpuSocket.Add(cpu);
            motherBoard.Add(gpu);
        }

        public void TraverseComputer(ComputerItem root)
        {
            foreach (ComputerItem item in root.GetChildren())
            {
                Console.WriteLine(item.ToString() + " is being visited");
                item.RepairOperation(visitor);

                TraverseComputer(item);
            }
        }
    }
}
