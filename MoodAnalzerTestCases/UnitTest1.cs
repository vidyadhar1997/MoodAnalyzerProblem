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
        public void GivenMood_WhenSad_ThenShouldReturnSadMood()
        {
            string Expected = "Sad";
            moodAnalyzer = new MoodAnalyzer("I am in Sad Mood");
            string mood = moodAnalyzer.analyseMood();
            Assert.AreEqual(Expected, mood);
        }
        ///<summary>
        /// TC 1.2 Given i am in Happy mood should return Happy mood.
        ///</summary>
        [TestMethod]
        public void GivenMood_WhenHappy_ThenShouldReturnHappyMood()
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
        public void GivenMood_WhenNull_ThenShouldReturnHappyMood(string message)
        {
            string Expected = "Happy";
            moodAnalyzer = new MoodAnalyzer(message);
            string mood = moodAnalyzer.analyseMood();
            Assert.AreEqual(Expected, mood);
        }
        /// <summary>
        /// TC 3.1 Given Mood when null should throw mood analysis exception
        /// </summary>
        [TestMethod]
        public void GivenMood_WhenNull_ThenShouldThrowMoodAnalysisException()
        {
            try
            {
                string message = null;
                moodAnalyzer = new MoodAnalyzer(message);
                string mood = moodAnalyzer.analyseMood();
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual("Mood Should Not Be Null", e.Message);
            }
        }
        /// <summary>
        /// TC 3.2 Given Empty Mood Should Throw MoodAnalysisException indicating Empty Mood
        /// </summary>
        [TestMethod]
        public void GivenMood_WhenEmpty_ThenShouldThrowMoodAnalysisException()
        {
            try
            {
                string message = "";
                moodAnalyzer = new MoodAnalyzer(message);
                string mood = moodAnalyzer.analyseMood();
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual("Mood Should Not Be Empty", e.Message);
            }
        }
    }
}