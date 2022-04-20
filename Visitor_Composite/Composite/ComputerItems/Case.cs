using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Composite.Visitor;

namespace Visitor_Composite.Composite
{
    public class Case : ComputerItem
    {
        private List<ComputerItem> computerItems;

        public Case(string name = "CASE") : base(name)
        {
            computerItems = new List<ComputerItem>();
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
            computerVisitor.RepairCase(this);
        }

        public void CaseReparationAction()
        {
            Console.WriteLine("Case is repairing");
        }
    }
}
