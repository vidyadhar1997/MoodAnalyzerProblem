using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyzerProblem;

namespace MoodAnalzerTestCases
{
    [TestClass]
    public class UnitTest1
    {
        private readonly MoodAnalyzer moodAnalyzer;
        public UnitTest1()
        {
            moodAnalyzer = new MoodAnalyzer();
        }
        [TestMethod]
        public void givenMood_WhenSad_ShouldReturnSadMood()
        {
            String mood=moodAnalyzer.analyseMood("Sad");
            Assert.AreEqual(mood, "Sad");
        }
        [TestMethod]
        public void givenMood_WhenHappy_ShouldReturnHappyMood()
        {
            String mood = moodAnalyzer.analyseMood("I am in Any mood");
            Assert.AreEqual(mood, "Happy");
        }
    }
}
