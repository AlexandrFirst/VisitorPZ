using System;
using System.Collections.Generic;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Place> places = new List<Place> { 
                new Museum(), new School(), new Park() 
            };
            PlaceVisitor visitor = new ConcretePlaceVisitor("Visitor 1");
            City city = new City();
            city.SetPlaces(places);
            city.Visit(visitor);
        }
    }
}
