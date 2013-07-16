using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubcarrierAllocation2
{
    class Station
    {
        public Point position;

        public int ID;
        
        public List<PRB> ownedPRB = new List<PRB>();

        public Station(Point _pos, int _id)
        {
            position = _pos;
            ID = _id;
        }

    }
}
