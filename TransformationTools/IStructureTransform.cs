using Zigma.Models;

namespace Zigma.TransformationTools
{
    internal interface IStructureTransform
    {
        public Zigma TransformColumnToDate(Zigma zDataset, int dateColumnNumber);
        public Zigma ColumnRemove(Zigma zDataset, int columnNumber);

    }
}
