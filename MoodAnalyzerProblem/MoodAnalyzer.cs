using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Mood Analyzer Problem");
        }
        public string analyseMood(string message)
        {
            if (message.Equals("Sad"))
            {
                return "Sad";
            }
            else 
            {
                return "Happy";
            }

        }
    }
}
