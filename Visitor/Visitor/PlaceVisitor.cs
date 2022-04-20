    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public abstract class PlaceVisitor
    {
        protected string Name { get; private set; }

        public PlaceVisitor(String name)
        {
            Name = name;
        }

        public abstract void VisitPark(Park park);
        public abstract void VisitMuseum(Museum museum);
        public abstract void VisitSchool(School school);
    }
}
