using System;

namespace mars_rover
{
    public class Position
    {
        public decimal X { get; set; }

        public decimal Y { get; set; }

        public Char FaceDirection { get; set; }

        public Position(decimal x, decimal y, char direction)
        {
            X = x;
            Y = y;
            FaceDirection = direction;
        }
    }
}
