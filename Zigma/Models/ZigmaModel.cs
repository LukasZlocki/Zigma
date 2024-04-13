namespace Zigma.Models
{
    public class ZigmaModel : ZigmaDataset, IZigmaModel
    {
        private int DatasetColumnsQuantity;
        private int DatasetRowsQuantity;
        private string ModelName;
        private ZigmaDataset zDataset = new();
        

        // CREATE
        /// <summary>
        /// Creating Zigma dataset from csv file.
        /// </summary>
        /// <param name="_zigmaDataset">Dataset</param>
        public void CreateZigmaDataset(ZigmaDataset _zDataset)
        {
            zDataset.zigmaDataset.Clear();
            zDataset = _zDataset;
            DatasetColumnsQuantity = CalculateColumnsQuantity(_zDataset.zigmaDataset);
            DatasetRowsQuantity = CalculateRowsQuantity(_zDataset.zigmaDataset);
        }

        public void CreateZigmaDatasetFromRawDataset(List<string[]> rawDataset)
        {
            zDataset.SetDataset(rawDataset);
        }

        // UPDATE
        /// <summary>
        /// Exchange old dataset with new dataset. Old dataset will be deleted.
        /// </summary>
        /// <param name="newDataset">New Zigma data set</param>
        public void UpdateZigmaDataset(ZigmaDataset _zDataset)
        {
            if (_zDataset != null)
            {
                zDataset.zigmaDataset.Clear();
                zDataset = _zDataset;
                CalculateColumnsQuantity(_zDataset.zigmaDataset);
                CalculateRowsQuantity(_zDataset.zigmaDataset);
            }
            else
            {
                Console.Write("Error. Not able to change dataset. Given data set is empty.");
            }
        }
        
        // GET
        /// <summary>
        /// Return Zigma dataset
        /// </summary>
        /// <returns>List<string[]></string></returns>
        public ZigmaDataset GetZigmaDataset()
        {
            return zDataset;
        }

        /// <summary>
        /// Return dataset as List<string[]>
        /// </summary>
        /// <returns>List<string></returns>
        public List<string[]> GetRawZigmaDataset()
        {
            return zDataset.GetDataset();
        }

        /// <summary>
        /// Printing Zigma dataset.
        /// </summary>
        /// <param name="zigmaDataset">Zigma dataset</param>
        /// <param name="quantityOfRowsToPrint">Number of rows to print</param>
        public void PrintZigmaDataset(int quantityOfRowsToPrint)
        {
            PrintZigmaDataset(zDataset.zigmaDataset, quantityOfRowsToPrint);
        }

        /// <summary>
        /// Printing Zigma dataset with specific quantity of rows.
        /// </summary>
        /// <param name="zigmaDataset"></param>
        /// <param name="quantityOfRowsToPrint">Number of rows to print.</param>
        private void PrintZigmaDataset(List<string[]> dataset, int quantityOfRowsToPrint)
        {
            int counter = 0;
            foreach (string[] element in dataset)
            {
                if (counter == quantityOfRowsToPrint)
                {
                    break;
                }
                string _showString = "" + counter + " ";
                for (int i = 0; i < element.Count(); i++)
                {
                    _showString = "" + _showString + ", " + "[ " + element[i] + " ]";
                }
                Console.WriteLine("" + _showString);
                counter++;
            }
            Console.WriteLine("");
            Console.WriteLine("Columns in dataset: " + DatasetColumnsQuantity);
            Console.WriteLine("Rows in dataset: " + DatasetRowsQuantity);
            Console.WriteLine("");
        }

        private int CalculateColumnsQuantity(List<string[]> dataset)
        {
            int _datasetColumnsQuantity = dataset[0].Length;
            return _datasetColumnsQuantity;
        }
        private int CalculateRowsQuantity(List<string[]> dataset)
        {
                int _datasetRawsQuantity = dataset.Count;
                return _datasetRawsQuantity;
        }

        public int GetDatasetColumnQuantity()
        {
            return DatasetColumnsQuantity;
        }

        public int GetDatasetRowQuantity()
        {
            return DatasetRowsQuantity;
        }

        public string GetModelName()
        {
            return ModelName;
        }

        public void SetModelName(string modelName)
        {
            ModelName = modelName;
        }

    }
}
