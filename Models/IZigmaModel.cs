namespace Zigma.Models
{
    internal interface IZigmaModel
    {
        // Create
        public void CreateZigmaDataset(ZigmaDataset zigmaDataset);
        // Create
        public void CreateZigmaDatasetFromRawDataset(List<string[]> rawDataset);
        // Get
        public ZigmaDataset GetZigmaDataset();
        // Update
        public void UpdateZigmaDataset(ZigmaDataset zigmaDataset);
        // Print
        public void PrintZigmaDataset(int quantityOfRowsToPrint);
    }
}
