
namespace BusinessLogicTest
{
    internal class ScoreData
    {
        public decimal MaxAvailable { get; set; }
        public decimal WeightedScoreBase { get; set; }
        public decimal PercentOfMax { get; set; }
        public decimal WeightedScore { get; set; }
    }

    internal class ScoreCard
    {
        public ScoreData TechCompetencyScore { get; set; }
        public ScoreData CoreCompetencyScore { get; set; }
        public decimal TotalWeightedScore { get; set; }
    }
}