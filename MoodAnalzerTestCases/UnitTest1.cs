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
        public void TestMethod1()
        {
            String mood=moodAnalyzer.analyseMood("Sad");
            Assert.AreEqual(mood, "Sad");

        }
    }
}
