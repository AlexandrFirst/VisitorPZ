using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Composite.Visitor;

namespace Visitor_Composite.Composite
{
    public class MotherBoard : ComputerItem
    {
        private List<ComputerItem> computerItems;
        public MotherBoard() : base("Motherboard")
        {
            computerItems = new List<ComputerItem>();
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
            computerItems.Add(item);
        }

        public override List<ComputerItem> GetChildren()
        {
            return computerItems;
        }

        public override void Remove(ComputerItem item)
        {
            computerItems.Remove(item);
        }

        public override void RepairOperation(ComputerVisitor computerVisitor)
        {
            computerVisitor.RepairMotherBoard(this);
        }

        public void RepairMotherBoardAction() 
        {
            Console.WriteLine("Repairing motherboard");
        }
    }
}
