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
        public void GivenMood_WhenNull_ThenShouldThrowMoodAnalyzerException()
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
        public void GivenMood_WhenEmpty_ThenShouldThrowMoodAnalyzerException()
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

        /// <summary>
        ///  TC 4.1 Given Mood Analyser class name should return moodAnalyzer object
        ///  MoodAnalyzerProblem<<-this is nameSpace
        ///  MoodAnalyzer<<-this is for class name and constructor name
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyzer_WhenClassName_ShouldReturnMoodAnalyzerObject()
        {
            string message = null;
            object expected = new MoodAnalyzer(message);
            object obj = MoodAnalyzerFactory.CreateMoodAnalyzer("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
        }

        /// <summary>
        /// TC 4.2 Given class name  when not proper then throw mood analyzer exception
        /// </summary>
        [TestMethod]
        public void GivenClassName_WhenImproper_ThenShouldThrowMoodAnalyzerException()
        {
            string expected = "Class Not Found";
            try
            {
                object obj = MoodAnalyzerFactory.CreateMoodAnalyzer("MoodAnalyzerProblem.WrongClass", "WrongClass");
            }
            catch (MoodAnalyzerException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// TC 4.3 Given class when constructor not proper then throw mood analyzer exception
        /// </summary>
        [TestMethod]
        public void GivenClass_WhenConstructorNotProper_ThenShouldThrowMoodAnalyzerException()
        {
            string expected = "Constructor is Not Found";
            try
            {
                object obj = MoodAnalyzerFactory.CreateMoodAnalyzer("MoodAnalyzerProblem.MoodAnalyzer", "WrongConstructor");
            }
            catch (MoodAnalyzerException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        ///  TC 5.1 Given Mood Analyser when class name with parameterized constructor should return object
        ///  MoodAnalyzerProblem<<-this is nameSpace
        ///  MoodAnalyzer<<-this is for class
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyzer_WhenClassName_ShouldReturnMoodAnalyzerObjectUsingParameterizedConstructor()
        {
            object expected = new MoodAnalyzer("Happy");
            object obj = MoodAnalyzerFactory.CreateMoodAnalyzerUsingParameterizedConstructor("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer", "Happy");
            expected.Equals(obj);
        }

        /// <summary>
        /// TC 5.2 Given class name  when not proper then throw no such class exception
        /// </summary>
        [TestMethod]
        public void GivenClassName_WhenImproper_ThenShouldThrowNoSuchClassException()
        {
            string expected = "Class Not Found";
            try
            {
                object obj = MoodAnalyzerFactory.CreateMoodAnalyzerUsingParameterizedConstructor("MoodAnalyzerProblem.WrongClass", "MoodAnalyzer", "Happy");
            }
            catch (MoodAnalyzerException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// TC 5.3 Given class when constructor not proper then throw no such constructor exception
        /// </summary>
        [TestMethod]
        public void GivenClass_WhenConstructorNotProper_ThenShouldThrowNoSuchConstructorException()
        {
            string expected = "Constructor is Not Found";
            try
            {
                object obj = MoodAnalyzerFactory.CreateMoodAnalyzerUsingParameterizedConstructor("MoodAnalyzerProblem.MoodAnalyzer", "WrongConstructor", "Happy");
            }
            catch (MoodAnalyzerException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        ///  TC 6.1 Given happy message using reflection when proper should return happy mood
        /// </summary>
        [TestMethod]
        public void GivenHappyMessage_WhenUsingReflection_ThenShouldReturnHappyMood()
        {
            string expected = "Happy";
            object obj = MoodAnalyzerFactory.InvokeAnalyseMood("Happy", "analyseMood");
            Assert.AreEqual(expected, obj);
        }

        /// <summary>
        ///  TC 6.2 Given happy message when improper methode then should throw 
        /// </summary>
        [TestMethod]
        public void GivenHappyMessage_WhenImproperMethode_ThenShouldThrowMoodAnalysisException()
        {
            string expected = "Method is not found";
            try
            {
                object obj = MoodAnalyzerFactory.InvokeAnalyseMood("Happy", "WrongAnalyseMood");
            }
            catch (MoodAnalyzerException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// TC 7.1 Given happy message with reflector then should return happy
        /// </summary>
        [TestMethod]
        public void GivenMessage_WhenHappyWithReflector_ThenShouldReturnHappy()
        {
            string Expected = "Happy";
            string result = MoodAnalyzerFactory.SetField("Happy", "message");
            Assert.AreEqual(result, Expected);
        }

        /// <summary>
        /// TC 7.2 Given field when improper then should throw exception with no such field
        /// </summary>
        [TestMethod]
        public void GivenField_WhenImproper_ThenShouldThrowNoSuchFieldException()
        {
            string Expected = "Field is not found";
            try
            {
                string result = MoodAnalyzerFactory.SetField("Happy", "WrongmessageField");
            }
            catch (MoodAnalyzerException exception)
            {
                Assert.AreEqual(Expected, exception.Message);
            }
        }

        /// <summary>
        /// TC 7.3 Given message when null then should throw exception message should not be null
        /// </summary>
        [TestMethod]
        public void GivenMessage_WhenNull_ThenShouldThrowMessageShouldNotNullException()
        {
            string Expected = "Message should not be null";
            try
            {
                string result = MoodAnalyzerFactory.SetField(null, "message");
            }
            catch (MoodAnalyzerException exception)
            {
                Assert.AreEqual(Expected, exception.Message);
            }
        }
    }
}