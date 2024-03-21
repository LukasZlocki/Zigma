using Zigma.Models;

namespace Zigma.ExtractionTools
{
    public class ExtractionTool : ICsvAdapter
    {
        private readonly CsvAdapter csvAdapter;

        public ExtractionTool()
        {
            csvAdapter = new CsvAdapter();
        }

        /// <summary>
        /// Load csv data to Zigma dataset
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="csvFileName"></param>
        /// <returns>a A <see cref="ZigmaDataset"/> object containing Zigma dataset</returns>
        public ZigmaDataset LoadFromCsvFile(string filePath, string csvFileName)
        {
            ZigmaDataset _zgimaDataset = csvAdapter.LoadFromCsvFile(filePath, csvFileName);
            return _zgimaDataset; 
        }

        /// <summary>
        /// Save Zigma dataset to csv file
        /// </summary>
        /// <param name="zigmaDataset"></param>
        /// <param name="filePath"></param>
        /// <param name="csvFileName"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void SaveToCsvFile(ZigmaDataset zigmaDataset, string filePath, string csvFileName)
        {
            csvAdapter.SaveToCsvFile(zigmaDataset, filePath, csvFileName);
        }
    }
}