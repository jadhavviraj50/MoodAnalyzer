using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
 
    public class MoodAnalyzer1
    {
        internal string message1;
        string message;
        public string AnalyseMood(string message)
        {

            if (message.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
            return message;

        }

    }
}
