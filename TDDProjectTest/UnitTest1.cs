using FluentAssertions;
using TDDProject;

namespace TDDProjectTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void RotateTest()
        {
            Compass testCompass = new Compass();
            var result = testCompass.Rotate(Point.North, Direction.Right);
            result.Should().Be(Point.East);
        }


    }
}