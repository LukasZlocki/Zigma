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

        /// <summary>
        /// Removing specific column from dataset.
        /// </summary>
        /// <param name="zDataset">Dataset to transform.</param>
        /// <param name="columnNumber">Column number to remove.</param>
        /// <returns>Transfored dataset - without specific column number</returns>
        public ZigmaModel ColumnRemove(ZigmaModel zModel, int columnNumber)
        {

            TransformationTool tservice = new();
            ZigmaModel _transformedModel = tservice.ColumnRemove(zModel, columnNumber);
            return _transformedModel;
        }

        /// <summary>
        /// Transforming given column number to date to date time format [yyyy/mm/dd]
        /// </summary>
        /// <param name="zDataset">Zigma dataset to date transform</param>
        /// <param name="dateColumnNumber">Column number to transform to date</param>
        /// <returns>Zigma dataset</returns>
        public ZigmaModel TransformColumnToDate(ZigmaModel zModel, int dateColumnNumber) 
        {
            return transform.TransformColumnToDate(zModel, dateColumnNumber);
        }
    }
}
