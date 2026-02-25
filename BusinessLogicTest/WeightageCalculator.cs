

namespace BusinessLogicTest
{
    /// <summary>
    /// 
    /// </summary>
    internal class WeightageCalculator
    {
        /// <summary>
        /// Get Score Card Data
        /// </summary>
        /// <param name="level"></param>
        /// <param name="techCompetencyRatingsTotal"></param>
        /// <param name="numberOfTechCompetencies"></param>
        /// <param name="coreCompetencyRatingsTotal"></param>
        /// <param name="numberOfCoreCompetencies"></param>
        /// <returns></returns>
        public static ScoreCard GetScoreCard(int level, decimal techCompetencyRatingsTotal, decimal numberOfTechCompetencies, decimal coreCompetencyRatingsTotal, decimal numberOfCoreCompetencies)
        {
            ScoreCard score = new ScoreCard();
            score.CoreCompetencyScore = GetScore(level, coreCompetencyRatingsTotal, numberOfCoreCompetencies);
            score.TechCompetencyScore = GetScore(level, techCompetencyRatingsTotal, numberOfTechCompetencies);
            score.TotalWeightedScore = Math.Round(score.CoreCompetencyScore.WeightedScoreBase + score.TechCompetencyScore.WeightedScoreBase, MidpointRounding.AwayFromZero);
            return score;
        }

        /// <summary>
        /// Gets the score
        /// based on total ratings
        /// </summary>
        /// <param name="level"></param>
        /// <param name="ratingsTotal"></param>
        /// <param name="numberOfParameters"></param>
        public static ScoreData GetScore(int level, decimal ratingsTotal, decimal numberOfParameters)
        {
            ScoreData score = new ScoreData();
            decimal variance = decimal.Parse(GetVariance(level).ToString());
            score.MaxAvailable = numberOfParameters * 4;

            MidpointRounding mpRounding = MidpointRounding.AwayFromZero;
            decimal dblBasePercOfMax = Math.Round(ratingsTotal / score.MaxAvailable, 2, mpRounding);
            score.PercentOfMax = Math.Round(decimal.Parse(dblBasePercOfMax.ToString()) * 100,2);
            score.WeightedScoreBase = Math.Round(score.PercentOfMax * variance,2, mpRounding);
            score.WeightedScore = Math.Round(score.PercentOfMax * variance, 0, mpRounding);
            return score;
        }

        /// <summary>
        /// Gets the Variance based on the Employee LEVEL
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        private static double GetVariance(int level)
        {
            double variance = 0.4;

            switch (level)
            { 
                case 5:
                    variance = 0.5;
                    break;
                case 6:
                    variance = 0.5;
                    break;
                case 7:
                    variance = 0.5;
                    break;
                case 8:
                    variance = 0.5;
                    break;
            }

            return variance;
        }
    }
}
