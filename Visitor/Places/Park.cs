using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Park : Place
    {
        public override void VisitedBy(PlaceVisitor visitor)
        {
            visitor.VisitPark(this);
        }

        public string SomePark() {
            return "Park is being visited";
        }
    }
}
