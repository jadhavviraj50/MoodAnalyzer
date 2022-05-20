// See https://aka.ms/new-console-template for more information


using MoodAnalyzerProblem;


Console.WriteLine("Welcome to Mood Analyzer Problem");

MoodAnalyzer1 analyzer = new();
string result = analyzer.AnalyseMood("I am in Happy mood");
Console.WriteLine(result);

MoodAnalyzer1 analyzer1 = new();
string result1 = analyzer1.AnalyseMood("I am in Sad mood");
Console.WriteLine(result1);

MoodAnalyser2 analyzer2 = new();
string result2 = analyzer2.AnalyseMood2();
Console.WriteLine("Default Constructor : " +result2);

MoodAnalyser2 analyzer3 = new("I am in Sad mood");
string result3 = analyzer3.AnalyseMood2();
Console.WriteLine("Parameterized Constructor : " +result3);

MoodAnalyse analyzer4 = new("Null");
string result4 = analyzer4.analysisMood();
Console.WriteLine("Handle Exception : " + result4);