using Zigma.Models;

namespace Zigma.ExtractionTools
{
    internal interface ICsvAdapter
    {
        public ZigmaDataset LoadFromCsvFile(string filePath, string csvFileName);
        public void SaveToCsvFile(ZigmaDataset zigmaDataset, string filePath, string csvFileName);
    }
}
