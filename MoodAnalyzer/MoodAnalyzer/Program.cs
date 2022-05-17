// See https://aka.ms/new-console-template for more information


using MoodAnalyzerProblem;

Console.WriteLine("Welcome to Mood Analyzer Problem");

MoodAnalyzer analyzer = new();
string result = analyzer.AnalyseMood("I am in Happy mood");
Console.WriteLine(result);
