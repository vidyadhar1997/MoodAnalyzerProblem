using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzerFactory
    {
        /// <summary>
        /// Creates the mood analyzer.
        /// </summary>
        /// <param name="className">Name of the class.</param>
        /// <param name="constructorName">Name of the constructor.</param>
        /// <returns>it returns null</returns>
        /// <exception cref="MoodAnalyzerException">
        /// Class Not Found exception is throw when condtion is not matched
        /// or
        /// Constructor is Not Found exception is throw when condtion is not matched
        /// </exception>
        public static object CreateMoodAnalyzer(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
                }
            }
            else
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_METHODE, "Constructor is Not Found");
            }
        }/// <summary>
        /// create mood analyzer using parameteized constructor
        /// </summary>
        /// <param name="className">class name is nothing but name of class</param>
        /// <param name="constructorName">constructor name is the constructor used in class</param>
        /// <param name="message">message will be any</param>
        /// <returns>message</returns>
        public static object CreateMoodAnalyzerUsingParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyzer);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) });
                    object instance = constructorInfo.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_METHODE, "Constructor is Not Found");
                }
            }
            else
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
            }
        }
        /// <summary>
        /// Invokes the analyse mood.
        /// </summary>
        /// <param name="message">The message will be any its depend on user</param>
        /// <param name="methodeName">create mood analyzer using parameterized constructor</param>
        /// <returns>message</returns>
        /// <exception cref="MoodAnalyzerException">Method is not found</exception>
        public static string InvokeAnalyseMood(string message, string methodeName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyzerProblem.MoodAnalyzer");
                object moodAnalyseObject = MoodAnalyzerFactory.CreateMoodAnalyzerUsingParameterizedConstructor("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer", message);
                MethodInfo methodeInfo = type.GetMethod(methodeName);
                object mood = methodeInfo.Invoke(moodAnalyseObject, null);
                return mood.ToString();
            }
            catch
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_METHODE, "Method is not found");
            }
        }
    }
}
