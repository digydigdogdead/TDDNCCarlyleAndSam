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

        [TestCase(TestName = "Testing multiple right rotations")]
        public void MultipleRightRotateTest()
        {
            Compass testCompass = new Compass();
            var result1 = testCompass.Rotate(Point.North, Direction.Right);
            var result2 = testCompass.Rotate(Point.East, Direction.Right);
            var result3 = testCompass.Rotate(Point.South, Direction.Right);
            var result4 = testCompass.Rotate(Point.West, Direction.Right);

            Assert.Multiple(() =>
            {
                result1.Should().Be(Point.East);
                result2.Should().Be(Point.South);
                result3.Should().Be(Point.West);
                result4.Should().Be(Point.North);
            });
        }
    }
}