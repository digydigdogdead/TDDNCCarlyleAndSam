using FluentAssertions;
using TDDProject;

namespace TDDProjectTest
{
    public class StringManipulatorTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ReverseStringTest()
        {
            StringManipulator stringManipulator = new StringManipulator();

            string testString = "egg";
            string expectedString = "gge";
            string result = stringManipulator.ReverseString(testString);

            result.Should().Be(expectedString);
        }

        [Test]
        public void IsPalindromeTest()
        {
            StringManipulator stringManipulator = new StringManipulator();

            string testString1 = "racecar";
            string testString2 = "egg";

            Assert.Multiple(() =>
            {
                stringManipulator.IsPalindrome(testString1).Should().BeTrue();
                stringManipulator.IsPalindrome(testString2).Should().BeFalse();
            });

        }
    }
}
