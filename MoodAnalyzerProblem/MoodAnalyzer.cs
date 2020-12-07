using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    class MoodAnalyzer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Mood Analyzer Problem");
        }
        public string analyseMood(string message)
        {
            if (message.Equals("Happy"))
            {
                return "Happy Mood";
            }
            else 
            {
                return "Sad Mood";
            }

        }
    }
}
