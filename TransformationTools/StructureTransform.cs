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
        public ZigmaModel ColumnCreateNew(Zigma zDataset)
        {
            throw new NotImplementedException();
        }

        public Zigma ColumnMove(Zigma zDataset, int columnNumberToMove, int newColumnPossitionNumber)
        {
            throw new NotImplementedException();
        }

        public Zigma ColumnRemove(Zigma zDataset, int columnNumber)
        {
            throw new NotImplementedException();
        }

        public Zigma ColumnSwitch(Zigma zDataset, int columnNumberToSwitch, int columnNumberSwitch)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Transforming given column number to date to date time format [yyyy/mm/dd]
        /// </summary>
        /// <param name="zDataset">Zigma dataset to date transform</param>
        /// <param name="dateColumnNumber">Column number to transform to date</param>
        /// <returns>Zigma dataset</returns>
        public Zigma TransformColumnToDate(Zigma zDataset, int dateColumnNumber)
        {
            Zigma transformedDataset = new ();
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
