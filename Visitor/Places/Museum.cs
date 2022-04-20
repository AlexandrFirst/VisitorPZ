using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Museum : Place
    {
        public override void VisitedBy(PlaceVisitor visitor)
        {
            visitor.VisitMuseum(this);
        }

        public string VisitingMuseum()
        {
            return "Museum is being visited";
        }
    }
}
