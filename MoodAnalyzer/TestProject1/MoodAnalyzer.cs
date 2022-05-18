using System;

namespace TestProject1
{
    internal class MoodAnalyzer
    {
        private string v;

        public MoodAnalyzer()
        {
        }

        public MoodAnalyzer(string v)
        {
            this.v = v;
        }

        internal string AnalyseMood(string v)
        {
            throw new NotImplementedException();
        }

        internal string AnalyseMood()
        {
            throw new NotImplementedException();
        }
    }
}