using Zigma.Models;

namespace Zigma.Terminal.Services
{
    internal class ModelManipulator
    {
        private ZigmaModel zModel;
        private Zigma zigmaManipulator;

        public ModelManipulator(string[] commands, ref Terminal terminalModel)
        {
            RunCommand(commands);
        }

        private void RunCommand(string[] commands)
        {
            ProcessCommandOnLevel0(commands);
        }

        private void ProcessCommandOnLevel0(string[] commands)
        {
            switch (commands[0]){
                case "extract":
                    // perform further commands here
                    break;
                case "help":
                    // perform further commands here
                    break;
                case "save":
                    // perform further commands here
                    break;
                case "model":
                    // perform further commands here
                    break;
                default:
                    Console.WriteLine("Unknow command.");
                    break;
            }
        }

        private void ProcessCommandOnLevel1_extract(string[] commands)
        {
            switch (commands[1])
            {
                case "csv":
                    // perform further commands here
                    var model = zigmaManipulator.extractionTool.LoadFromCsvFile(commands[3], commands[2]);
                    zModel.CreateZigmaDataset(zigmaManipulator.zigmaModel.GetZigmaDataset());
                    break;

                default:
                    Console.WriteLine("Unknow command.");
                    break;
            }
        }

        private void ProcessCommandOnLevel1_save(string[] commands)
        {
            switch (commands[1])
            {
                case "csv":
                    // save data from model to csv file and path name
                    Console.WriteLine("Saving data to csv file name: {0}, path: {1}.", commands[2], commands[3]);
                    break;
                default:
                    Console.WriteLine("Unknow command.");
                    break;
            }
        }

        private void ProcessCommandOnLevel1_help(string[] commands)
        {
            Console.WriteLine("Show help here...");
        }

        private void ProcessCommandOnLevel1_model(string[] commands)
        {
            switch (commands[1])
            {
                case "create":
                    // perform further commands here
                    break;
                case "show":
                    // perform further commands here
                    break;
                case "activate":
                    // perform further commands here
                    break;
                case "rename":
                    // perform further commands here
                    break;
                case "column":
                    // perform further commands here
                    break;
                default:
                    Console.WriteLine("Unknow command.");
                    break;
            }
        }


        private void ProcessCommandOnLevel2_model_show(string[] commands)
        {
            switch (commands[2])
            {
                case "name":
                    // perform further commands here
                    break;
                case "models":
                    // perform further commands here
                    break;
                case "data":
                    // perform further commands here
                    break;
                case "alldata":
                    // perform further commands here
                    break;
                case "rows":
                    // perform further commands here
                    break;
                default:
                    Console.WriteLine("Unknow command.");
                    break;
            }
        }

        private void ProcessCommandOnLevel3_model_show_rows(string[] commands)
        {
            switch (commands[3])
            {
                case "last":
                    // perform further commands here
                    break;
                case "first":
                    // perform further commands here
                    break;
                default:
                    Console.WriteLine("Unknow command.");
                    break;
            }
        }

        private void ProcessCommandOnLevel2_model_column(string[] commands)
        {
            switch (commands[2])
            {
                case "rename":
                    // perform further commands here
                    break;
                case "remove":
                    // perform further commands here
                    break;
                case "switch":
                    // perform further commands here
                    break;
                default:
                    Console.WriteLine("Unknow command.");
                    break;
            }
        }
    }
}
