using Zigma.Models;

namespace Zigma.TransformationTools
{
    public class TransformationTool : IStructureTransform
    {
        private readonly StructureTransform transform;

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
            ZigmaModel _transformedModel = transform.ColumnRemove(zModel, columnNumber);
            return _transformedModel;
        }

        /// <summary>
        /// Extracting column to new Zigma model
        /// </summary>
        /// <param name="zModel">Zigma model dataset</param>
        /// <param name="columnToExtract"Column number to extract</param>
        /// <returns>Zigma model</returns>
        public ZigmaModel ColumnExtract(ZigmaModel zModel, int columnToExtract)
        {
            ZigmaModel _zModel = new ();
            _zModel = transform.ColumnExtract(zModel, columnToExtract);
            return _zModel;
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

        public ZigmaModel RemoveRecurrenceData(ZigmaModel zModel, int ColumnWithRecurrence)
        {
            ZigmaModel _transformedModel = transform.RemoveRecurrenceData(zModel, ColumnWithRecurrence);
           return _transformedModel;
        }
    }
}
