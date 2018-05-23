namespace mars_rover.Implementation
{
    class North : IDirection
    {
        public Position Move(Position current, char input)
        {
            switch (input)
            {
                case 'R':
                    current.FaceDirection = 'E';
                    break;

                case 'L':
                    current.FaceDirection = 'W';
                    break;

                case 'M':
                    current.Y += 1;
                    break;
            }
            return current;
        }
    }
}
