using Zigma.Models;
using Zigma.ExtractionTools;
using Zigma.TransformationTools;

namespace Zigma
{

    public class Zigma : IStructureTransform, IZigmaModel
    {
        private ZigmaModel model;
        private StructureTransform structTransform;
        public FileIOAdapter loader;

        public ExtractionTool extractionTool;
        
        public Zigma()
        {
            extractionTool = new ExtractionTool();

            model = new ZigmaModel();
            structTransform = new StructureTransform();
            loader = new FileIOAdapter();
        }

        #region ZigmaModel
        /// <summary>
        /// Exchange old dataset with new dataset. Old dataset will be deleted.
        /// </summary>
        /// <param name="newDataset">New Zigma data set.</param>
        public void ChangeDataset(List<string[]> newDataset)
        {
            model.ChangeDataset(newDataset);
        }

        /// <summary>
        /// Printing Zigma whole dataset.
        /// </summary>
        public void PrintDataset()
        {
            model.PrintDataset();
        }

        /// <summary>
        /// Printing Zigma dataset with specific quantity of rows.
        /// </summary>
        /// <param name="zigmaDataset">Zigma dataset.</param>
        /// <param name="quantityOfRowsToPrint">Number of rows to print</param>
        public void PrintDataset(List<string[]> zigmaDataset, int quantityOfRowsToPrint)
        {
            model.PrintDataset(zigmaDataset, quantityOfRowsToPrint);
        }

        /// <summary>
        /// Creating Zigma dataset from csv file.
        /// </summary>
        /// <param name="dataset">List of strings with coma separators</param>
        public void CreateZigmaModel(List<string> csvModel)
        {
            model.CreateZigmaModel(csvModel);
        }
        #endregion

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
