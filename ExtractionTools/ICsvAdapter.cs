namespace Zigma.ExtractionTools
{
    internal interface ICsvAdapter
    {
        public void SaveToCsvFile(List<string> dataSet, string filePath, string csvFileName);
    }
}
