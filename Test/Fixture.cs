using mars_rover;
using System;
using Xunit;

namespace Test
{
    public class Fixture
    {
        private Rover _rover;

        [Fact]
        public void Test1()
        {
            var position = new Position(0, 0, 'N');
            _rover = new Rover(position);
            _rover.Move("MMM");
            var result = _rover.GetCurrentPosition();
            Assert.Equal(0, result.X);
            Assert.Equal(3, result.Y);
            Assert.Equal('N', result.FaceDirection);
        }

        [Fact]
        public void Test2()
        {
            var position = new Position(0, 1, 'E');
            _rover = new Rover(position);
            _rover.Move("MML");
            var result = _rover.GetCurrentPosition();
            Assert.Equal(2, result.X);
            Assert.Equal(1, result.Y);
            Assert.Equal('N', result.FaceDirection);
        }

        [Fact]
        public void Test3()
        {
            var position = new Position(10, 5, 'N');
            _rover = new Rover(position);
            _rover.Move("MMLMRMMLk");
            var result = _rover.GetCurrentPosition();
            Assert.Equal(9, result.X);
            Assert.Equal(9, result.Y);
            Assert.Equal('W', result.FaceDirection);
        }
    }
}
