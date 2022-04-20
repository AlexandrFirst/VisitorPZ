using System;
using Visitor;
using Visitor_Composite.Composite;
using Visitor_Composite.Visitor;

namespace Visitor_Composite
{
    internal class Program
    {
        public ComputerVisitor ComputerVisitor
        {
            get => default;
            set
            {
            }
        }

        public Device Device
        {
            get => default;
            set
            {
            }
        }

        static void Main(string[] args)
        {
            ComputerVisitor computerVisitor = new ConcreteComputerVisitor();

            Computer computer = new Computer(computerVisitor);

            PlaceVisitor visitor = new ConcretePlaceVisitor("Visitor 1");
            Device city = new Device();
            city.SetComputer(computer);
            city.Visit();
        }
    }
}
