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
            ZigmaDataset _zDataset = new ();
            try
            {
                using (StreamReader reader = new (filePath + csvFileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');

                        // You can add more error handling here if needed.
                        _zDataset.zigmaDataset.Add(values);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading from CSV file: {ex.Message}");
            }
            return _zDataset;
        }

        public void SaveToCsvFile(List<string[]> dataset, string filePath, string csvFileName)
        {
            string fullPath = filePath + csvFileName;
            try
            {
                using (StreamWriter sw = new (fullPath))
                {
                    foreach (string[] line in dataset)
                    {
                        sw.WriteLine(string.Join(",", line));
                    }
                }
                Console.WriteLine("Data has been successfully saved to CSV file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving to CSV file: {ex.Message}");
            }

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
            List<string[]> rawDatset = new List<String[]>();
            rawDatset = zigmaDataset.GetDataset();
            SaveToCsvFile(rawDatset, filePath, csvFileName);
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

        /// <summary>
        /// Convert Csv data as List<string> to Zigma model
        /// </summary>
        /// <param name="dataset">csv list of strings</param>
        /// <returns>Zigma model</returns>
        public ZigmaModel ConvertCsvToZigmaModel(List<string> dataset)
        {
            ZigmaModel _zModel = new ();
            List<string[]> _newDataList = new ();
            // ToDo: Write unit test for the class
            foreach (string element in dataset)
            {
                string[] divString = element.Split(',');
                _newDataList.Add(divString);
            }
            _zModel.zigmaDataset = _newDataList;
            return _zModel;
        }


    }
}