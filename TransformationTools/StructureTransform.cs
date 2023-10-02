using System.Data;
using Zigma.Models;

namespace Zigma.TransformationTools
{

    // ToDo ZIGMA | TransformTool | Add method to create new column (add new column at the end of dataset)
    // ToDo ZIGMA | TransformTool | Add method to remove column
    // ToDo Zigma | TransformTool | Add method to move particular column to new possition ex: no move column nb 5 to 3) rest columns will move +1 column (ColumnMove(a, c)) 
    // ToDo Zigma | TransformTool | Add method to switch columns ex: switch column 3 with column 2 (ColumnSwitch(a, b))
    // ToDo Zigma | TransformTool | Add method to divide date by day / week / month and sign what to do with rest of columns (+, -, *, /)
    // ToDo Zigma | TransformTool | Add method to do math operation in particular column -ex: have result in particular column (operation +, - , * , /, )

    internal class StructureTransform : IStructureTransform
    {
        /// <summary>
        /// Removing specific column from dataset.
        /// </summary>
        /// <param name="zModel">Model with dataset to transform.</param>
        /// <param name="columnNumber">Column number to remove.</param>
        /// <returns>Transfored model with dataset. Specific column removed.</returns>
        public ZigmaModel ColumnRemove(ZigmaModel zModel, int columnNumber)
        {
            ZigmaDataset _zDataset = zModel.GetZigmaDataset();
            ZigmaDataset _transformedDataset = new();
            foreach (string[] row in _zDataset.zigmaDataset)
            {
                int _rowElementsQuantity = row.Length;
                string[] _transformedRow = new string[_rowElementsQuantity];
                int _elementCounter = 0;
                foreach (string element in row)
                {
                    if (_elementCounter == columnNumber)
                    {
                        continue; // skipping this column 
                    }
                    else
                    {
                        _transformedRow[_elementCounter] = element;
                    }
                    _transformedDataset.zigmaDataset.Add(_transformedRow);
                }
            }
            ZigmaModel transformedModel = new();
            transformedModel.CreateZigmaDataset(_transformedDataset);
            return transformedModel;
        }

        /// <summary>
        /// Transforming given column number to date to date time format [yyyy/mm/dd]
        /// </summary>
        /// <param name="zDataset">Zigma dataset to date transform</param>
        /// <param name="dateColumnNumber">Column number to transform to date</param>
        /// <returns>Zigma dataset</returns>
        public ZigmaModel TransformColumnToDate(ZigmaModel zModel, int dateColumnNumber)
        {
            ZigmaModel transformedDataset = new ();
            /*
            // ToDo: Code logic here
            double daysToAdd;
            string formattedDate;
            DateTime dateConverted;
            DateTime baseDate = new DateTime(1900, 1, 1);

            foreach (string[] element in MainDataset) {

                string elementToConvert = element[columnNumber];
                try
                {
                    daysToAdd = Convert.ToDouble(elementToConvert);
                    dateConverted = baseDate + TimeSpan.FromDays(daysToAdd);
                    formattedDate = dateConverted.ToString("yyyy/MM/dd");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                    continue;
                }
                if (formattedDate != "" || formattedDate != null) {
                    element[columnNumber] = formattedDate;
                } 
            }
            */
            return transformedDataset;
        }

    }
}
