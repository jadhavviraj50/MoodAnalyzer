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

    }
}