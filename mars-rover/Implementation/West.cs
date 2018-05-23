namespace mars_rover.Implementation
{
    class West : IDirection
    {
        public Position Move(Position current, char input)
        {
            switch (input)
            {
                case 'R':
                    current.FaceDirection = 'N';
                    break;

                case 'L':
                    current.FaceDirection = 'S';
                    break;

                case 'M':
                    current.X -= 1;
                    break;
            }
            return current;
        }
    }
}
