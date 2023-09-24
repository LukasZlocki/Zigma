namespace Zigma.TransformationTools
{
    public class TransformationTool : IStructureTransform
    {
        private StructureTransform transform;

        //constructor
        public TransformationTool()
        {
            transform = new StructureTransform();
        }

        public void ConvertCsvToListOfStringArrayStructure(List<string> dataset)
        {
            throw new NotImplementedException();
        }

        public List<string> ConvertListOfStringArrayStructureToCsv(List<string[]> dataset)
        {
            throw new NotImplementedException();
        }

        public List<string[]> GetDataset()
        {
            throw new NotImplementedException();
        }

        public void PrintDataset(int quantityOfRowsToPrint)
        {
            throw new NotImplementedException();
        }
    }
}
