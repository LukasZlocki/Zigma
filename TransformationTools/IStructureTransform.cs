namespace Zigma.TransformationTools
{
    internal interface IStructureTransform
    {
        public Zigma TransformColumnToDate(Zigma zDataset, int dateColumnNumber);
        public Zigma ColumnCreateNew(Zigma zDataset);
        public Zigma ColumnRemove(Zigma zDataset, int columnNumber);
        public Zigma ColumnMove(Zigma zDataset, int columnNumberToMove, int newColumnPossitionNumber);
        public Zigma ColumnSwitch(Zigma zDataset, int columnNumberToSwitch, int columnNumberSwitch);
    }
}
