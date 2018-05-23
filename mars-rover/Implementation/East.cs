namespace mars_rover.Implementation
{
    class East : IDirection
    {
        public Position Move(Position current, char input)
        {
            switch (input)
            {
                case 'R':
                    current.FaceDirection = 'S';
                    break;

                case 'L':
                    current.FaceDirection = 'N';
                    break;

                case 'M':
                    current.X += 1;
                    break;
            }
            return current;
        }
    }
}
