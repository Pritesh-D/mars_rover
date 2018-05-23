using mars_rover.Implementation;
using System;

namespace mars_rover
{
    class DirectionFactory
    {
        public static IDirection GetInstance(char currentDirection)
        {
            switch (currentDirection)
            {
                case 'E':
                    return new East();

                case 'W':
                    return new West();

                case 'S':
                    return new South();

                case 'N':
                    return new North();

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
