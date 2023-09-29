namespace Zigma.Models
{
    public class ZigmaModel : ZigmaDataset, IZigmaModel
    {
        private int DatasetColumnsQuantity;
        private int DatasetRowsQuantity;

        // CREATE
        /// <summary>
        /// Creating Zigma dataset from csv file.
        /// </summary>
        /// <param name="_zigmaDataset">Dataset</param>
        public void CreateZigmaDataset(ZigmaDataset _zDataset)
        {
            zigmaDataset = _zDataset.zigmaDataset;
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
                zigmaDataset.Clear();
                zigmaDataset = _zDataset.zigmaDataset;
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
            ZigmaDataset _zDataset = new ZigmaDataset();
            _zDataset.zigmaDataset = zigmaDataset;
            return _zDataset;
        }

        /// <summary>
        /// Printing Zigma dataset.
        /// </summary>
        /// <param name="zigmaDataset">Zigma dataset</param>
        /// <param name="quantityOfRowsToPrint">Number of rows to print</param>
        public void PrintZigmaDataset(int quantityOfRowsToPrint)
        {
            PrintZigmaDataset(zigmaDataset, quantityOfRowsToPrint);
        }

        /// <summary>
        /// Printing Zigma whole dataset.
        /// </summary>
        public void PrintZigmaDataset()
        {
            PrintZigmaDataset(zigmaDataset, 0);
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
        }

        private int CalculateColumnsQuantity(List<string[]> dataset)
        {
            int _columnsQuantity = dataset[0].Length;
            return _columnsQuantity;
        }
       private int CalculateRowsQuantity(List<string[]> dataset)
        {
            int _rowsQuantity = dataset.Count;
            return _rowsQuantity;
        }

    }
}
