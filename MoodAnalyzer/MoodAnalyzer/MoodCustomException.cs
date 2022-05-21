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
            NULL_MOOD, EMPTY_MOOD, NO_SUCH_CLASS, NO_SUCH_METHOD, NO_SUCH_FIELD
        }
        public ExpType exceptionType;
        public MoodCustomException(ExpType type, string message) : base(message)
        {
            this.exceptionType = type;
        }

    }
}
