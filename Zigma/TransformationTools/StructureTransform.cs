using System.Data;
using System.Diagnostics.Metrics;
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
                int _newRowElementsQuantity = row.Length - 1; // removing one row
                string[] _transformedRow = new string[_newRowElementsQuantity];
                int _oldTablePossitionCounter = 0; // possition on column in old table
                int _newTablePossitionCounter = 0; // column possition in new table without one column
                foreach (string element in row)
                {
                    if (_oldTablePossitionCounter == columnNumber)
                    {
                        _oldTablePossitionCounter = _oldTablePossitionCounter + 1;
                        continue; // skipping this column 
                    }
                    else
                    {
                        _transformedRow[_newTablePossitionCounter] = element;
                    }
                    _oldTablePossitionCounter = _oldTablePossitionCounter + 1;
                    _newTablePossitionCounter = _newTablePossitionCounter + 1;
                }
                _transformedDataset.zigmaDataset.Add(_transformedRow);
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
            ZigmaDataset _zDataset = zModel.GetZigmaDataset();
            ZigmaDataset _transformedDataset = new();
            List<string[]> transformedDataset = new List<string[]>();
            foreach (string[] row in _zDataset.zigmaDataset)
            {
                int counter = 0;
                string[] _transformedRow = new string[row.Length];
                foreach (string column in row)
                {
                    if (counter == dateColumnNumber)
                    {
                        _transformedRow[counter] = ConvertToSimpleDate(column);
                        counter++;
                        continue;
                    }
                    else
                    {
                        _transformedRow[counter] = column;
                        counter++;
                    }
                }
                _transformedDataset.zigmaDataset.Add(_transformedRow);
            };
            ZigmaModel _transformedModel = new();
            _transformedModel.CreateZigmaDataset(_transformedDataset);
            return _transformedModel;
        }

        private string ConvertToSimpleDate(string dateToConvert)
        {
            string _convertedDate;
            try
            {
                DateTime imputDate = DateTime.ParseExact(dateToConvert, "yyyy-MM-dd HH:mm:ss", null);
                _convertedDate = imputDate.ToString("yyyy-MM-dd");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return dateToConvert;
            }
            return _convertedDate;
        }

        public ZigmaModel ColumnExtract(ZigmaModel zModel, int columnToExtract)
        {
            ZigmaModel _zModel = new();
            List<string[]> _extractedColumn = new List<string[]>();
            foreach(string[] row in zModel.GetRawZigmaDataset()){
                string[] _element = new string [] { row[columnToExtract] };
                _extractedColumn.Add(_element);
            }
            _zModel.CreateZigmaDatasetFromRawDataset(_extractedColumn);
            return _zModel;
        }

        public ZigmaModel RemoveRecurrenceData(ZigmaModel zModel, int ColumnWithRecurrence)
        {
            ZigmaModel _zModelRecurrenceRemoved = new ZigmaModel();
            List<string> _nonRecurrenceElements = new List<string>();
            List<string[]> _rawZigmaDataset = new List<string[]>();
            foreach(var row in zModel.GetRawZigmaDataset()){
                if(_nonRecurrenceElements.Exists(x => x == row[ColumnWithRecurrence])) {
                    continue;
                }
                else {
                    _rawZigmaDataset.Add(row);
                    _nonRecurrenceElements.Add(row[ColumnWithRecurrence]); // adding new element to list of recurrence lements
                }
            }
            _zModelRecurrenceRemoved.CreateZigmaDatasetFromRawDataset(_rawZigmaDataset);
            return _zModelRecurrenceRemoved;
        }


    }
}
