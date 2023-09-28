namespace Zigma.TransformationTools
{
    internal class StructureTransform : IStructureTransform
    {
        /// <summary>
        /// Transforming given column number to date [yyyy/mm/dd].
        /// </summary>
        /// <param name="columnNumber">Column number to transform into date.</param>
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
