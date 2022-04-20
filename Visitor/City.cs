using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class City
    {
        List<Place> places;
        
        public City()
        {
            places = new List<Place>();
        }

        public void SetPlaces(List<Place> places) 
        {
            this.places = places;
        }

        public void Visit(PlaceVisitor visitor) 
        {
            foreach (Place place in places)
            {
                place.VisitedBy(visitor);
            }
        }
    }
}
