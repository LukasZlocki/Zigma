using Zigma.Models;
using Zigma.ExtractionTools;
using Zigma.TransformationTools;

namespace Zigma
{
    public class Zigma
    {
        public ExtractionTool extractionTool;
        public TransformationTool transformationTool;
        public ZigmaModel zigmaModel;

        public Zigma()
        {
            extractionTool = new ExtractionTool();
            transformationTool = new TransformationTool();
            zigmaModel = new ZigmaModel();
        }
    }
}
