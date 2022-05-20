using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void GivenInputIsString_WhenTestAnalyseMood_ShouldReturnSad()
        {
            MoodAnalyzer1 analyser = new MoodAnalyzer1();
            string expected = analyser.AnalyseMood("I am in sad mood");
            Assert.AreEqual("SAD", expected);
        }

        [TestMethod]
        public void GivenInputIsString_WhenTestAnalyseMood_ShouldReturnHappy()
        {
            MoodAnalyzer1 analyser = new MoodAnalyzer1();
            string expected = analyser.AnalyseMood("I am in any mood");
            Assert.AreEqual("HAPPY", expected);
        }

        [TestMethod]
        public void GivenInputStringConstructor_ShouldReturnSad()
        {
            MoodAnalyser2 analyser = new MoodAnalyser2();
            string expected = analyser.AnalyseMood2();
            Assert.AreEqual("SAD", expected);
        }

        [TestMethod]
        public void GivenInputStringConstructor1_ShouldReturnSad()
        {
            MoodAnalyser2 analyser = new MoodAnalyser2("I am in Happy Mood");
            string expected = analyser.AnalyseMood2();
            Assert.AreEqual("HAPPY", expected);
        }
        [TestMethod]
        public void GivenNullMood_ShouldReturnHappy()
        {
            MoodAnalyse analyser = new MoodAnalyse("Null");
            string expected = analyser.analysisMood();
            Assert.AreEqual("Happy", expected);
        }
    }
}