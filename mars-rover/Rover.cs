namespace mars_rover
{
    public class Rover
    {
        private Position _position;

        public Rover(Position position)
        {
            _position = position;
        }

        public void Move(string input)
        {
            foreach (var move in input)
                _position = DirectionFactory.GetInstance(_position.FaceDirection).Move(_position, move);
        }

        public Position GetCurrentPosition()
        {
            return _position;
        }
    }
}
