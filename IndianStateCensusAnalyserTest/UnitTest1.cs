using IndianStateCensusAnalyser;

namespace IndianStateCensusAnalyserTest
{
    public class Tests
    {
        public string stateCensusFilePath = @"D:\BridgeLabz\IndianStateCensusAnalyser\IndianStateCensusAnalyserTest\Files\StateCensusData.csv";
        [Test]
        public void GivenStateCensusData_WhenAnalyzed_ShouldReturn_NoOfRecordsMatches()
        {
            StateCensusAnalyzer analyzer = new StateCensusAnalyzer();
            CSVStateCensus stateCensus = new CSVStateCensus();
            Assert.AreEqual(stateCensus.ReadStateCensusData(stateCensusFilePath), analyzer.ReadStateCensusData(stateCensusFilePath));
        }
    }
}