using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodCustomException : Exception
    {
        public enum ExpType
        {
            Empty_Message, Null_Message
        }
        public readonly ExpType type;
       
        public MoodCustomException(ExpType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
