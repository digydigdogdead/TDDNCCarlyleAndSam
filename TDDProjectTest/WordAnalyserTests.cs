using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDProject;

namespace TDDProjectTest
{
    internal class WordAnalyserTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void FindLongestWordsTest()
        {
            WordAnalyser analyser = new WordAnalyser();

            string words1 = "This is a fairly boring sentence.";
            string words2 = "This is a fairly boring thing.";

            Assert.Multiple(() =>
            {
                analyser.FindLongestWords(words1).Should().Contain("sentence").And.HaveCount(1);
                analyser.FindLongestWords(words2).Should().Contain("fairly").And.Contain("boring").And.HaveCount(2);
            });
        }

        [Test]
        public void CalculateLetterFrequencyTest()
        {
            WordAnalyser analyser = new WordAnalyser();

            string string1 = "Hello world";
            string string2 = "This is a fairly boring thing.";

            Dictionary<char, int> string1Frequencies = new Dictionary<char, int>()
            {
                { 'a', 0 },
                { 'b', 0 },
                { 'c', 0 },
                { 'd', 1 },
                { 'e', 1 },
                { 'f', 0 },
                { 'g', 0 },
                { 'h', 1 },
                { 'i', 0 },
                { 'j', 0 },
                { 'k', 0 },
                { 'l', 3 },
                { 'm', 0 },
                { 'n', 0 },
                { 'o', 2 },
                { 'p', 0 },
                { 'q', 0 },
                { 'r', 1 },
                { 's', 0 },
                { 't', 0 },
                { 'u', 0 },
                { 'v', 0 },
                { 'w', 1 },
                { 'x', 0 },
                { 'y', 0 },
                { 'z', 0 }
            };

            Dictionary<char, int> string2Frequencies = new Dictionary<char, int>()
            {
                { 'a', 2 },
                { 'b', 1 },
                { 'c', 0 },
                { 'd', 0 },
                { 'e', 0 },
                { 'f', 1 },
                { 'g', 2 },
                { 'h', 2 },
                { 'i', 5 },
                { 'j', 0 },
                { 'k', 0 },
                { 'l', 1 },
                { 'm', 0 },
                { 'n', 2 },
                { 'o', 1 },
                { 'p', 0 },
                { 'q', 0 },
                { 'r', 2 },
                { 's', 2 },
                { 't', 2 },
                { 'u', 0 },
                { 'v', 0 },
                { 'w', 0 },
                { 'x', 0 },
                { 'y', 1 },
                { 'z', 0 }
            };


            Assert.Multiple(() =>
            {
                Dictionary<char, int> result1 = analyser.CalculateLetterFrequency(string1);

                foreach (var key in string1Frequencies.Keys)
                {
                    result1[key].Should().Be(string1Frequencies[key]);
                }
            });

            Assert.Multiple(() =>
            {
                Dictionary<char, int> result2 = analyser.CalculateLetterFrequency(string2);

                foreach (var key in string2Frequencies.Keys)
                {
                    result2[key].Should().Be(string2Frequencies[key]);
                }
            });

        }


    }
}
