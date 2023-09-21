namespace Zigma.Models
{
    internal interface IZigmaModel
    {
        // Create
        public void CreateZigmaDataset(ZigmaDataset zigmaDataset);
        // Get
        public ZigmaDataset GetZigmaDataset();
        // Update
        public void UpdateZigmaDataset(ZigmaDataset zigmaDataset);
        // Print
        public void PrintZigmaDataset(int quantityOfRowsToPrint);
        public void PrintZigmaDataset();
        public void PrintZigmaDataset(ZigmaDataset zigmaDataset, int quantityOfRowsToPrint);
        public void PrintThisZigmaDataset(ZigmaDataset zigmaDataset);
    }
}
