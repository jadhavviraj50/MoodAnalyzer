// See https://aka.ms/new-console-template for more information


using MoodAnalyzerProblem;

Console.WriteLine("Welcome to Mood Analyzer Problem");

MoodAnalyzer1 analyzer = new();
string result = analyzer.AnalyseMood("I am in Happy mood");

MoodAnalyzer1 analyzer1 = new();
string result1 = analyzer1.AnalyseMood("I am in Sad mood");

Console.WriteLine(result);
Console.WriteLine(result1);
