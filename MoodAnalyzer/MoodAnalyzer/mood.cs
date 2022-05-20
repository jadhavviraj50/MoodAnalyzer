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
                if (message1.Equals(string.Empty))
                {
                    throw new MoodCustomException(MoodCustomException.ExpType.Empty_Message, "Mood should not be empty");
                }
                if (message1.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodCustomException(MoodCustomException.ExpType.Null_Message, "Mood should not be Null");
            }

        }
    }
}