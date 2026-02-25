using BusinessLogicTest;

namespace BusinessLogicUnitTest
{
    public class Level5_UnitTest
    {
        [Fact]
        public void TestLevel5_3And3_Probability3and3()
        {
            // setup Data
            int jobLevel = 5;
            int totalCoreCompetencies = 3;
            int totalTechCompetencies = 3;
            int techCompetencyTotalScore = 3;
            int coreCompetencyTotalScore = 3;

            ScoreCard card = WeightageCalculator.GetScoreCard(jobLevel, techCompetencyTotalScore, totalTechCompetencies, coreCompetencyTotalScore, totalCoreCompetencies);

            Assert.Equal(13, card.TechCompetencyScore.WeightedScore);
            Assert.Equal(13, card.CoreCompetencyScore.WeightedScore);
            
            Assert.Equal(25, card.TotalWeightedScore);
            Assert.Equal(25, card.TechCompetencyScore.PercentOfMax);
            Assert.Equal(25, card.CoreCompetencyScore.PercentOfMax);
        }

        [Fact]
        public void TestLevel5_3And3_Probability3and4()
        {
            // setup Data
            int jobLevel = 5;
            int totalCoreCompetencies = 3;
            int totalTechCompetencies = 3;

            int techCompetencyTotalScore = 3;
            int coreCompetencyTotalScore = 4;

            ScoreCard card = WeightageCalculator.GetScoreCard(jobLevel, techCompetencyTotalScore, totalTechCompetencies, coreCompetencyTotalScore, totalCoreCompetencies);

            Assert.Equal(13, card.TechCompetencyScore.WeightedScore);
            Assert.Equal(17, card.CoreCompetencyScore.WeightedScore);
            
            Assert.Equal(29, card.TotalWeightedScore);
            Assert.Equal(25, card.TechCompetencyScore.PercentOfMax);
            Assert.Equal(33, card.CoreCompetencyScore.PercentOfMax);
        }

        [Fact]
        public void TestLevel5_3And3_Probability3and5()
        {
            // setup Data
            int jobLevel = 5;
            int totalCoreCompetencies = 3;
            int totalTechCompetencies = 3;

            int techCompetencyTotalScore = 3;
            int coreCompetencyTotalScore = 5;

            ScoreCard card = WeightageCalculator.GetScoreCard(jobLevel, techCompetencyTotalScore, totalTechCompetencies, coreCompetencyTotalScore, totalCoreCompetencies);

            Assert.Equal(13, card.TechCompetencyScore.WeightedScore);
            Assert.Equal(21, card.CoreCompetencyScore.WeightedScore);
            Assert.Equal(34, card.TotalWeightedScore);
            Assert.Equal(25, card.TechCompetencyScore.PercentOfMax);
            Assert.Equal(42, card.CoreCompetencyScore.PercentOfMax);
        }

        [Fact]
        public void TestLevel5_3And3_Probability3and6()
        {
            // setup Data
            int jobLevel = 5;
            int totalCoreCompetencies = 3;
            int totalTechCompetencies = 3;

            int techCompetencyTotalScore = 3;
            int coreCompetencyTotalScore = 6;

            ScoreCard card = WeightageCalculator.GetScoreCard(jobLevel, techCompetencyTotalScore, totalTechCompetencies, coreCompetencyTotalScore, totalCoreCompetencies);

            Assert.Equal(13, card.TechCompetencyScore.WeightedScore);
            Assert.Equal(25, card.CoreCompetencyScore.WeightedScore);
            Assert.Equal(38, card.TotalWeightedScore);
            Assert.Equal(25, card.TechCompetencyScore.PercentOfMax);
            Assert.Equal(50, card.CoreCompetencyScore.PercentOfMax);
        }

        [Fact]
        public void TestLevel5_3And3_Probability3and7()
        {
            // setup Data
            int jobLevel = 5;
            int totalCoreCompetencies = 3;
            int totalTechCompetencies = 3;

            int techCompetencyTotalScore = 3;
            int coreCompetencyTotalScore = 7;

            ScoreCard card = WeightageCalculator.GetScoreCard(jobLevel, techCompetencyTotalScore, totalTechCompetencies, coreCompetencyTotalScore, totalCoreCompetencies);

            Assert.Equal(13, card.TechCompetencyScore.WeightedScore);
            Assert.Equal(29, card.CoreCompetencyScore.WeightedScore);
            Assert.Equal(42, card.TotalWeightedScore);
            Assert.Equal(25, card.TechCompetencyScore.PercentOfMax);
            Assert.Equal(58, card.CoreCompetencyScore.PercentOfMax);
        }

        [Fact]
        public void TestLevel5_3And3_Probability3and8()
        {
            // setup Data
            int jobLevel = 5;
            int totalCoreCompetencies = 3;
            int totalTechCompetencies = 3;

            int techCompetencyTotalScore = 3;
            int coreCompetencyTotalScore = 8;

            ScoreCard card = WeightageCalculator.GetScoreCard(jobLevel, techCompetencyTotalScore, totalTechCompetencies, coreCompetencyTotalScore, totalCoreCompetencies);

            Assert.Equal(13, card.TechCompetencyScore.WeightedScore);
            Assert.Equal(34, card.CoreCompetencyScore.WeightedScore);
            Assert.Equal(46, card.TotalWeightedScore);
            Assert.Equal(25, card.TechCompetencyScore.PercentOfMax);
            Assert.Equal(67, card.CoreCompetencyScore.PercentOfMax);
        }

        [Fact]
        public void TestLevel5_3And3_Probability3and9()
        {
            // setup Data
            int jobLevel = 5;
            int totalCoreCompetencies = 3;
            int totalTechCompetencies = 3;

            int techCompetencyTotalScore = 3;
            int coreCompetencyTotalScore = 9;

            ScoreCard card = WeightageCalculator.GetScoreCard(jobLevel, techCompetencyTotalScore, totalTechCompetencies, coreCompetencyTotalScore, totalCoreCompetencies);

            Assert.Equal(13, card.TechCompetencyScore.WeightedScore);
            Assert.Equal(38, card.CoreCompetencyScore.WeightedScore);
            Assert.Equal(50, card.TotalWeightedScore);

            Assert.Equal(25, card.TechCompetencyScore.PercentOfMax);
            Assert.Equal(75, card.CoreCompetencyScore.PercentOfMax);
        }

        [Fact]
        public void TestLevel5_3And3_Probability3and10()
        {
            // setup Data
            int jobLevel = 5;
            int totalCoreCompetencies = 3;
            int totalTechCompetencies = 3;

            int techCompetencyTotalScore = 3;
            int coreCompetencyTotalScore = 10;

            ScoreCard card = WeightageCalculator.GetScoreCard(jobLevel, techCompetencyTotalScore, totalTechCompetencies, coreCompetencyTotalScore, totalCoreCompetencies);

            Assert.Equal(13, card.TechCompetencyScore.WeightedScore);
            Assert.Equal(42, card.CoreCompetencyScore.WeightedScore);
            Assert.Equal(54, card.TotalWeightedScore);

            Assert.Equal(25, card.TechCompetencyScore.PercentOfMax);
            Assert.Equal(83, card.CoreCompetencyScore.PercentOfMax);
        }


        [Fact]
        public void TestLevel5_3And3_Probability4and4()
        {
            // setup Data
            int jobLevel = 5;
            int totalCoreCompetencies = 3;
            int totalTechCompetencies = 3;

            int techCompetencyTotalScore = 4;
            int coreCompetencyTotalScore = 4;

            ScoreCard card = WeightageCalculator.GetScoreCard(jobLevel, techCompetencyTotalScore, totalTechCompetencies, coreCompetencyTotalScore, totalCoreCompetencies);

            Assert.Equal(17, card.TechCompetencyScore.WeightedScore);
            Assert.Equal(17, card.CoreCompetencyScore.WeightedScore);
            Assert.Equal(33, card.TotalWeightedScore);

            Assert.Equal(33, card.TechCompetencyScore.PercentOfMax);
            Assert.Equal(33, card.CoreCompetencyScore.PercentOfMax);
        }

        [Fact]
        public void TestLevel5_3And3_Probability4and5()
        {
            // setup Data
            int jobLevel = 5;
            int totalCoreCompetencies = 3;
            int totalTechCompetencies = 3;

            int techCompetencyTotalScore = 4;
            int coreCompetencyTotalScore = 5;

            ScoreCard card = WeightageCalculator.GetScoreCard(jobLevel, techCompetencyTotalScore, totalTechCompetencies, coreCompetencyTotalScore, totalCoreCompetencies);

            Assert.Equal(17, card.TechCompetencyScore.WeightedScore);
            Assert.Equal(21, card.CoreCompetencyScore.WeightedScore);
            Assert.Equal(38, card.TotalWeightedScore);

            Assert.Equal(33, card.TechCompetencyScore.PercentOfMax);
            Assert.Equal(42, card.CoreCompetencyScore.PercentOfMax);
        }

        [Fact]
        public void TestLevel5_3And3_Probability4and6()
        {
            // setup Data
            int jobLevel = 5;
            int totalCoreCompetencies = 3;
            int totalTechCompetencies = 3;

            int techCompetencyTotalScore = 4;
            int coreCompetencyTotalScore = 6;

            ScoreCard card = WeightageCalculator.GetScoreCard(jobLevel, techCompetencyTotalScore, totalTechCompetencies, coreCompetencyTotalScore, totalCoreCompetencies);

            Assert.Equal(17, card.TechCompetencyScore.WeightedScore);
            Assert.Equal(25, card.CoreCompetencyScore.WeightedScore);
            Assert.Equal(42, card.TotalWeightedScore);

            Assert.Equal(33, card.TechCompetencyScore.PercentOfMax);
            Assert.Equal(50, card.CoreCompetencyScore.PercentOfMax);
        }

        [Fact]
        public void TestLevel5_3And3_Probability4and7()
        {
            // setup Data
            int jobLevel = 5;
            int totalCoreCompetencies = 3;
            int totalTechCompetencies = 3;

            int techCompetencyTotalScore = 4;
            int coreCompetencyTotalScore = 6;

            ScoreCard card = WeightageCalculator.GetScoreCard(jobLevel, techCompetencyTotalScore, totalTechCompetencies, coreCompetencyTotalScore, totalCoreCompetencies);

            Assert.Equal(17, card.TechCompetencyScore.WeightedScore);
            Assert.Equal(25, card.CoreCompetencyScore.WeightedScore);
            Assert.Equal(42, card.TotalWeightedScore);

            Assert.Equal(33, card.TechCompetencyScore.PercentOfMax);
            Assert.Equal(50, card.CoreCompetencyScore.PercentOfMax);
        }


        //[Fact]
        //public void TestLevel5_3And4_Probability()
        //{
        //    // setup Data
        //    int jobLevel = 5;

        //    int totalTechCompetencies = 3;
        //    int techCompetencyTotalScore = 3;

        //    int coreCompetencyTotalScore = 3;
        //    int totalCoreCompetencies = 3;

        //    ScoreCard card = WeightageCalculator.GetScoreCard(jobLevel, techCompetencyTotalScore, totalTechCompetencies, coreCompetencyTotalScore, totalCoreCompetencies);

        //    Assert.Equal(13, card.CoreCompetencyScore.WeightedScore);
        //    Assert.Equal(13, card.TechCompetencyScore.WeightedScore);
        //    Assert.Equal(25, card.TotalWeightedScore);
        //}

        //[Fact]
        //public void TestLevel5_And4_Probability()
        //{
        //    // setup Data
        //    int jobLevel = 5;
        //    int totalCoreCompetencies = 3;
        //    int totalTechCompetencies = 3;
        //    int techCompetencyTotalScore = 3;
        //    int coreCompetencyTotalScore = 3;

        //    ScoreCard card = WeightageCalculator.GetScoreCard(jobLevel, techCompetencyTotalScore, totalTechCompetencies, coreCompetencyTotalScore, totalCoreCompetencies);

        //    Assert.Equal(13, card.CoreCompetencyScore.WeightedScore);
        //    Assert.Equal(13, card.TechCompetencyScore.WeightedScore);
        //    Assert.Equal(25, card.TotalWeightedScore);
        //}
    }
}