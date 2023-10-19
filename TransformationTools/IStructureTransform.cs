using Zigma.Models;

namespace Zigma.TransformationTools
{
    internal interface IStructureTransform
    {
        public ZigmaModel TransformColumnToDate(ZigmaModel zModel, int dateColumnNumber);
        public ZigmaModel ColumnRemove(ZigmaModel zModel, int columnNumber);
        public ZigmaModel ColumnExtract(ZigmaModel zModel, int columnToExtract);
    }
}
