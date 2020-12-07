using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyzerProblem;

namespace MoodAnalzerTestCases
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyzer moodAnalyzer = null;
        public UnitTest1()
        {
          
        }
        [TestMethod]
        public void givenMood_WhenSad_ShouldReturnSadMood()
        {
            moodAnalyzer = new MoodAnalyzer("I am in Sad Mood");
            string mood=moodAnalyzer.analyseMood();
            Assert.AreEqual("Sad",mood);
        }
        [TestMethod]
        public void givenMood_When_ShouldReturnHappyMood()
        {
            moodAnalyzer = new MoodAnalyzer("I am in happy Mood");
            string mood = moodAnalyzer.analyseMood();
            Assert.AreEqual("Happy", mood);
        }
        [TestMethod]
        public void givenMood_WhenNull_ShouldReturnHappyMood()
        {
            moodAnalyzer = new MoodAnalyzer(null);
            string mood = moodAnalyzer.analyseMood();
            Assert.AreEqual("Happy", mood);
        }
    }
}
