namespace mars_rover
{
    interface IDirection
    {
        Position Move(Position current, char input);
    }
}
