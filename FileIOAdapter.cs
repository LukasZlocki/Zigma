﻿using Zigma.ExtractionTools;

namespace Zigma
{
    public class FileIOAdapter : ICsvAdapter
    {
        private CsvAdapter csvIOLoader;

        public FileIOAdapter()
        {
            csvIOLoader = new CsvAdapter();
        }

        /// <summary>
        /// Save data from list os strings array (string line in format [data1, data2, data3, data4, ...) to csv file
        /// </summary>
        /// <param name="dataSet">Dataset to convert to csv file as list of strings array.</param>
        /// <param name="filePath">Output file path.</param>
        /// <param name="csvFileName">Output csv file name.</param>
        public void SaveToCsvFile(List<string> dataSet, string filePath, string csvFileName)
        {
            throw new NotImplementedException();
        }
    }
}
