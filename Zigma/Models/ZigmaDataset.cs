namespace Zigma.Models
{
    public class ZigmaDataset
    {
        internal List<string[]> zigmaDataset;

        internal ZigmaDataset()
        {
            zigmaDataset = new();
        }

        public void SetDataset(List<string[]> newDataset)
        {
            zigmaDataset = newDataset;
        }

        public List<string[]> GetDataset()
        {
            return zigmaDataset;
        }
    }
}
