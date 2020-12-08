using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyzerProblem;

namespace MoodAnalzerTestCases
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyzer moodAnalyzer = null;
        ///<summary>
        /// Default constructor
        ///</summary>
        public UnitTest1()
        {
          
        }
        ///<summary>
        /// TC 1.1 Given i am in sad mood should return sad mood.
        ///</summary>
        [TestMethod]
        public void GivenMood_WhenSad_ShouldReturnSadMood()
        {
            string Expected = "Sad";
            moodAnalyzer = new MoodAnalyzer("I am in Sad Mood");
            string mood=moodAnalyzer.analyseMood();
            Assert.AreEqual(Expected, mood);
        }
        ///<summary>
        /// TC 1.2 Given i am in Happy mood should return Happy mood.
        ///</summary>
        [TestMethod]
        public void GivenMood_WhenHappy_ShouldReturnHappyMood()
        {
            string Expected = "Happy";
            moodAnalyzer = new MoodAnalyzer("I am in happy Mood");
            string mood = moodAnalyzer.analyseMood();
            Assert.AreEqual(Expected, mood);
        }
        ///<summary>
        /// TC 2.1 Given null mood should return happy mood.
        ///</summary>
        [TestMethod]
        [DataRow(null)]
        public void GivenMood_WhenNull_ShouldReturnHappyMood(string message)
        {
            string Expected = "Happy";
            moodAnalyzer = new MoodAnalyzer(message);
            string mood = moodAnalyzer.analyseMood();
            Assert.AreEqual(Expected, mood);
        }
    }
}
