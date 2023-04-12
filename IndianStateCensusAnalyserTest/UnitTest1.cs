using IndianStateCensusAnalyser;

namespace IndianStateCensusAnalyserTest
{
    public class Tests
    {
        public string stateCensusFilePath = @"D:\BridgeLabz\IndianStateCensusAnalyser\IndianStateCensusAnalyserTest\Files\StateCensusData.csv";
        public string stateCensusTypeFilePath = @"D:\BridgeLabz\IndianStateCensusAnalyser\IndianStateCensusAnalyserTest\Files\StateCensusData.txt";
        public string stateCensusDelimeterFilePath = @"D:\BridgeLabz\IndianStateCensusAnalyser\IndianStateCensusAnalyserTest\Files\StateCensusDataDelimeter.csv";
        public string stateCensusHeaderFilePath = @"D:\BridgeLabz\IndianStateCensusAnalyser\IndianStateCensusAnalyserTest\Files\StateCensusDataHeader.csv";
        [Test]
        public void GivenStateCensusData_WhenAnalyzed_ShouldReturn_NoOfRecordsMatches()
        {
            StateCensusAnalyzer analyzer = new StateCensusAnalyzer();
            CSVStateCensus stateCensus = new CSVStateCensus();
            Assert.AreEqual(stateCensus.ReadStateCensusData(stateCensusFilePath), analyzer.ReadStateCensusData(stateCensusFilePath));
        }
        [Test]
        public void GivenStateCensusDataFileIncorrect_WhenAnalyze_ShouldReturn_Exception()
        {
            StateCensusAnalyzer analyzer = new StateCensusAnalyzer();
            try
            {
                int records = analyzer.ReadStateCensusData(stateCensusFilePath);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect file path");
            }
        }
        [Test]
        public void GivenStateCensusDataFileTypeIncorrect_WhenAnalyze_ShouldReturn_Exception()
        {
            StateCensusAnalyzer analyzer = new StateCensusAnalyzer();
            try
            {
                int records = analyzer.ReadStateCensusData(stateCensusTypeFilePath);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect file type");
            }
        }
        [Test]
        public void GivenStateCensusDataFileDelimeterIncorrect_WhenAnalyze_ShouldReturn_Exception()
        {
            StateCensusAnalyzer analyzer = new StateCensusAnalyzer();
            try
            {
                int records = analyzer.ReadStateCensusData(stateCensusDelimeterFilePath);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect delimeter");
            }
        }
        [Test]
        public void GivenStateCensusDataFileHeaderIncorrect_WhenAnalyze_ShouldReturn_Exception()
        {
            StateCensusAnalyzer analyzer = new StateCensusAnalyzer();
            try
            {
                bool records = analyzer.ReadStateCensusData(stateCensusHeaderFilePath, "State,Population,AreaInSqKm,DensityPerSqKm");
                Assert.IsTrue(records);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect Header");
            }
        }
    }
}