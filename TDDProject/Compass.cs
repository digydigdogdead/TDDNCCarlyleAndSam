using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    public class Compass
    {
        public Point Point { get; private set; }
        public Point Rotate(Point startingPoint, Direction direction)
        {
            return Point.South;
        }
    }
}
