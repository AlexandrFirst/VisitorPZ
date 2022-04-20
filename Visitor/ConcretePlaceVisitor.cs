using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ConcretePlaceVisitor : PlaceVisitor
    {
        public ConcretePlaceVisitor(string name) : base(name)
        {
        }

        public override void VisitMuseum(Museum museum)
        {
            Log(museum.VisitingMuseum());
        }

        public override void VisitPark(Park park)
        {
            Log(park.SomePark());
        }

        public override void VisitSchool(School school)
        {
            Log(school.VisitSchool());
        }

        private void Log(String action) {
            Console.WriteLine(base.Name + ": " + action);
        }
    }
}
