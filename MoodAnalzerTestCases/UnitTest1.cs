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
            string Expected = "Sad";
            moodAnalyzer = new MoodAnalyzer("I am in Sad Mood");
            string mood=moodAnalyzer.analyseMood();
            Assert.AreEqual(Expected, mood);
        }
        [TestMethod]
        public void givenMood_When_ShouldReturnHappyMood()
        {
            string Expected = "Happy";
            moodAnalyzer = new MoodAnalyzer("I am in happy Mood");
            string mood = moodAnalyzer.analyseMood();
            Assert.AreEqual(Expected, mood);
        }
        [TestMethod]
        [DataRow(null)]
        public void givenMood_WhenNull_ShouldReturnHappyMood(string message)
        {
            string Expected = "Happy";
            moodAnalyzer = new MoodAnalyzer(message);
            string mood = moodAnalyzer.analyseMood();
            Assert.AreEqual(Expected, mood);
        }
    }
}
