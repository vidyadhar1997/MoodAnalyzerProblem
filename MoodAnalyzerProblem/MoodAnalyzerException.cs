﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    class MoodAnalyzerException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            NO_SUCH_FIELD,
            NO_SUCH_METHODE,
            NO_SUCH_CLASS,
            OBJECT_CREATION_ISSUE
        }
        ExceptionType type;
        /// <summary>
        /// Mood Analyzer Exception parameterized constructor
        /// </summary>
        /// <param name="type">The type</param>
        /// <param name="message">The message.</param>
        public MoodAnalyzerException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}