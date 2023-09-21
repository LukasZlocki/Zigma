using System.Data;
using Zigma.Models;

namespace Zigma.ExtractionTools
{
    internal class CsvAdapter : ICsvAdapter
    {


        // READ
        /// <summary>
        /// Load csv data to Zigma dataset
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="csvFileName"></param>
        /// <returns>a A <see cref="ZigmaDataset"/> object containing Zigma dataset</returns>
        public ZigmaDataset LoadFromCsvFile(string filePath, string csvFileName)
        {
            ZigmaDataset _zDataset = new ZigmaDataset();
            // ToDo: Code loading data from csv file here
            // ToDo: write class transfering List<string> csv to zigma model
            return _zDataset;
        }

        /// <summary>
        /// Save data from list os strings array (string line in format [data1, data2, data3, data4, ...) to csv file
        /// </summary>
        /// <param name="ZigmaDataset">Zigma dataset to convert to csv file</param>
        /// <param name="filePath">Output file path.</param>
        /// <param name="csvFileName">Output csv file name.</param>
        public void SaveToCsvFile(ZigmaDataset zigmaDataset, string filePath, string csvFileName)
        {
            // ToDo: write class transfering zigma model to List<string> to save as csv
            List<string> dataSet = new List<string>(); // ToDo: code transfering of data from zigmna to List<string>here
            string fullPath = filePath + csvFileName;
            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath))
                {
                    foreach (string line in dataSet)
                    {
                        sw.WriteLine(line);
                    }
                }
                Console.WriteLine("Data has been successfully saved to CSV file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving to CSV file: {ex.Message}");
            }
        }
     /*
    private ZigmaDataset ConvertDataToZigmaModel(List<string> datasetToConvert)
        {
            List<string[]> _newDataList = new List<string[]>();
            // ToDo: Write unit test for the class
            foreach (string element in datasetToConvert)
            {
                string[] divString = element.Split(',');
                _newDataList.Add(divString);
            }
            ZigmaDataset = _newDataList;
        }
     */
    }
}