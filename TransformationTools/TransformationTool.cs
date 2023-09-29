using Zigma.Models;

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
            return transform.TransformColumnToDate(zDataset, dateColumnNumber);
        }
    }
}
