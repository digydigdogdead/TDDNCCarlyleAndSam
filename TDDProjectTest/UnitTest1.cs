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
        public void Test1()
        {
            Compass testCompass = new Compass();
            testCompass.Rotate(Point.North, Direction.Right);
            testCompass.Point.Should().Be(Point.East);
        }
    }
}