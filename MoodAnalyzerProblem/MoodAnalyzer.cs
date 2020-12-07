using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        private string message;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Mood Analyzer Problem");
        }
        public MoodAnalyzer()
        {

        }
        public MoodAnalyzer(String message)
        {
            this.message = message;
        }
        public string analyseMood()
        {
            try
            {
                if (message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
