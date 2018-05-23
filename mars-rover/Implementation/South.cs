namespace mars_rover.Implementation
{
    class South : IDirection
    {
        public Position Move(Position current, char input)
        {
            switch (input)
            {
                case 'R':
                    current.FaceDirection = 'W';
                    break;

                case 'L':
                    current.FaceDirection = 'E';
                    break;

                case 'M':
                    current.Y -= 1;
                    break;
            }
            return current;
        }
    }
}
