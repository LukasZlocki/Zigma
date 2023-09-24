using Zigma.Models;
using Zigma.ExtractionTools;
using Zigma.TransformationTools;

namespace Zigma
{

    public class Zigma
    {
        private StructureTransform structTransform;

        public ExtractionTool extractionTool;
        public ZigmaModel zigmaModel;

        public Zigma()
        {
            extractionTool = new ExtractionTool();
            zigmaModel = new ZigmaModel();

            structTransform = new StructureTransform();
        }

        #region StructureTransform
        // ToDo: Method moved to ZIGMA or convert to zigma during reading from csv
        /// <summary>
        /// Converting csv do Zigma dataset
        /// </summary>
        /// <param name="dataset">list of string with csv</param>
        public void ConvertCsvToListOfStringArrayStructure(List<string> dataset)
        {
            structTransform.ConvertCsvToListOfStringArrayStructure(dataset);
        }

        /// <summary>
        /// Convert Zigma dataset to csv
        /// </summary>
        /// <param name="dataset">Zigma dataset</param>
        /// <returns>List<string></returns>
        public List<string> ConvertListOfStringArrayStructureToCsv(List<string[]> dataset)
        {
            return structTransform.ConvertListOfStringArrayStructureToCsv(dataset);
        }

        /// <summary>
        /// Returns Zigma dataset
        /// </summary>
        /// <returns>Zigma dataset</returns>
        public List<string[]> GetDataset()
        {
            return structTransform.GetDataset();
        }

        // ToDo: Method move to Zigma
        /// <summary>
        /// Prints rows of dataset.
        /// </summary>
        /// <param name="quantityOfRowsToPrint">Quantity of rows to print. 0 - print all rows.</param>
        public void PrintDataset(int quantityOfRowsToPrint)
        {
            structTransform.PrintDataset(quantityOfRowsToPrint);
        }
        #endregion


    }
}
