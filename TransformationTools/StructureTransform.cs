namespace Zigma.TransformationTools
{
    internal class StructureTransform : IStructureTransform
    {
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
