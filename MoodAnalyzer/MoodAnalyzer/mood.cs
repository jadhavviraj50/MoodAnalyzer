using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyse
    {

        string message1;
       
        public MoodAnalyse(string message)
        {
            message1 = message;
        }
       
        public string analysisMood()
        {
            try
            {
                if (message1.ToUpper().Contains("Sad"))
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
                return "Happy";
            }

        }
    }
}