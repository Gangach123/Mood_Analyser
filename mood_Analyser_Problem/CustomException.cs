using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mood_Analyser_Problem
{
    public class CustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
            CLASS_NOT_FOUND, CONSTRUCTOR_NOT_FOUND
        }
        public ExceptionType Type;

        public CustomException(ExceptionType type, string Message) : base(Message)
        {
            Type = type;
        }
    }
}
