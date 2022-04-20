using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class School : Place
    {
        public override void VisitedBy(PlaceVisitor visitor)
        {
            visitor.VisitSchool(this);
        }

        public string VisitSchool()
        {
            return "School is being visited";
        }
    }
}
