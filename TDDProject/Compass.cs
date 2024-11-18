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
            int startingInt = (int)startingPoint;

            if (direction == Direction.Left)
            {
                int finishingPoint = startingInt - 1;
                if (finishingPoint < 0) finishingPoint = 3;
                return (Point)finishingPoint;
            }
            else
            {
                int finishingPoint = startingInt + 1;
                if (finishingPoint == 4) finishingPoint = 0;
                return (Point)finishingPoint;
            }
            
        }
    }
}
