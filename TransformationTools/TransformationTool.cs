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

        /// <summary>
        /// Transforming given column number to date to date time format [yyyy/mm/dd]
        /// </summary>
        /// <param name="zDataset">Zigma dataset to date transform</param>
        /// <param name="dateColumnNumber">Column number to transform to date</param>
        /// <returns>Zigma dataset</returns>
        public Zigma TransformColumnToDate(Zigma zDataset, int dateColumnNumber) 
        {
            return transform.TransformColumnToDate(zDataset, dateColumnNumber);
        }
    }
}
