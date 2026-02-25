// See https://aka.ms/new-console-template for more information
using BusinessLogicTest;

Console.WriteLine("Weightage Calculator");
int jobLevel = 5;
int totalScore = 11;
int totalCompetencies = 3;

ScoreData testScore1 = WeightageCalculator.GetScore(jobLevel,totalScore,totalCompetencies);
Console.WriteLine(testScore1.WeightedScore);

int jobLevel = 5;
int totalScore = 11;
int totalCompetencies = 3;
ScoreData testScore2 = WeightageCalculator.GetScore(jobLevel, totalScore, totalCompetencies);
Console.WriteLine(testScore2.WeightedScore);

//double score2 = WeightageCalculator.GetScore(jobLevel, totalScore, totalCompetencies);
//Console.WriteLine(score2);
Console.ReadLine();
