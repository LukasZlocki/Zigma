using Zigma.Models;

namespace Zigma.Terminal.Services
{
    internal class ModelManipulator
    {
        private Zigma zigmaManipulator;
        private ZigmaModel zigmaModel;

        public ModelManipulator(string[] commands, ref Terminal terminalModel)
        {
            zigmaManipulator = new();
            zigmaModel = new();
            RunCommand(commands, ref terminalModel);
        }

        private void RunCommand(string[] commands, ref Terminal terminalModel)
        {
            ProcessCommandOnLevel0(commands, ref terminalModel);
        }

        private void ProcessCommandOnLevel0(string[] commands, ref Terminal terminalModel)
        {
            switch (commands[0]){
                case "extract":
                     ProcessCommandOnLevel1_extract(commands, ref terminalModel);
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
                case "exit":
                    // exit
                    break;
                default:
                    Console.WriteLine("Unknow command.");
                    break;
            }
        }

        private void ProcessCommandOnLevel1_extract(string[] commands, ref Terminal terminalModel)
        {
            switch (commands[1])
            {
                case "csv":
                    var model = zigmaManipulator.extractionTool.LoadFromCsvFile(commands[3], commands[2]); // loading csv to zigma model
                    zigmaModel.CreateZigmaDataset(zigmaManipulator.zigmaModel.GetZigmaDataset());
                    terminalModel.AddNewZigmaModel(zigmaModel);
                    Console.WriteLine("Data loaded to model from csv file.");
                    break;

                default:
                    Console.WriteLine("Unknow command.");
                    break;
            }
        }

        private void ProcessCommandOnLevel1_save(string[] commands, ref Terminal terminalModel)
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

        private void ProcessCommandOnLevel1_help(string[] commands, ref Terminal terminalModel)
        {
            Console.WriteLine("Show help here...");
        }

        private void ProcessCommandOnLevel1_model(string[] commands, ref Terminal terminalModel)
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


        private void ProcessCommandOnLevel2_model_show(string[] commands, ref Terminal terminalModel)
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

        private void ProcessCommandOnLevel3_model_show_rows(string[] commands, ref Terminal terminalModel)
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

        private void ProcessCommandOnLevel2_model_column(string[] commands, ref Terminal terminalModel)
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
