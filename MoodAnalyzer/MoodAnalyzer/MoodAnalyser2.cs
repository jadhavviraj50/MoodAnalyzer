using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyser2
    {

        public MoodAnalyser2()
        {

        }
        public string message1 = "I am in sad mood";
        public MoodAnalyser2(string message)
        {
            this.message1 = message;
        }
        public string AnalyseMood2()
        {
            string message2 = "SAD";

            if (message1.ToUpper().Contains(message2.ToUpper()))
            {
                return message2;
            }
            else
            {
                return "HAPPY";
            }
        }

        public string AnalyseMood1()
        {
            throw new NotImplementedException();
        }
    }
}