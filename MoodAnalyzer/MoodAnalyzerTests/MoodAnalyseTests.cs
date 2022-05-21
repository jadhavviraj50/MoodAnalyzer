using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem.Tests
{
    [TestClass()]
    public class MoodAnalyseTests
    {
        [TestMethod()]
        public void GivingEmptyMood_ShouldReturnException_EmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalyse moodanlysis = new MoodAnalyse(message);
                string actual = moodanlysis.analysisMood();
            }
            catch (MoodCustomException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void GivingNullMood_ShouldReturnException_NullMood()
        {
            try
            {
                string message = null;
                MoodAnalyse moodanlysis = new MoodAnalyse(message);
                string actual = moodanlysis.analysisMood();
            }
            catch (MoodCustomException e)
            {
                Assert.AreEqual("Mood should not be Null", e.Message);
            }
        }
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldreturnObject()
        {
            string message = null;
            object expected = new MoodAnalyse(message);
            object obj = MoodAnlyserFactory.CreateMoodAnalyser("MoodAnalyser.MoodAnalyse", "MoodAnalyse");
            expected.Equals(obj);
        }

        
    }
}
