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
                    Console.WriteLine("extract");
                    ProcessCommandOnLevel1_extract(commands, ref terminalModel);
                    break;
                case "help":
                    // perform further commands here
                    Console.WriteLine("help");
                    break;
                case "save":
                    // perform further commands here
                    Console.WriteLine("save");
                    break;
                case "model":
                    Console.WriteLine("model");
                    ProcessCommandOnLevel1_model(commands, ref terminalModel);
                    break;
                case "clear":
                    Console.WriteLine("clear");
                    Console.Clear();
                    break;
                case "exit":
                    Console.WriteLine("exit");
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
                    Console.WriteLine("csv");
                    // ToDo: check if string has / sign if not add it
                    var model = zigmaManipulator.extractionTool.LoadFromCsvFile(commands[2], commands[3]); // loading csv to zigma model
                    zigmaModel.CreateZigmaDataset(model);
                    zigmaModel.SetModelName("noname");
                    terminalModel.AddNewZigmaModel(zigmaModel);
                    Console.WriteLine("Data loaded to model from csv file.");
                    break;

                default:
                    Console.WriteLine("extract - Unknow command.");
                    Console.WriteLine("Unknow command.");
                    break;
            }
        }

        private void ProcessCommandOnLevel1_save(string[] commands, ref Terminal terminalModel)
        {
            switch (commands[1])
            {
                case "csv":
                    Console.WriteLine("csv");
                    // save data from model to csv file and path name
                    Console.WriteLine("Saving data to csv file name: {0}, path: {1}.", commands[2], commands[3]);
                    break;
                default:
                    Console.WriteLine("save - Unknow command.");
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
                    Console.WriteLine("show");
                    ProcessCommandOnLevel2_model_show(commands, ref terminalModel);
                    break;
                case "activate":
                    // perform further commands here
                    break;
                case "rename":
                    // perform further commands here
                    zigmaModel = terminalModel.GetActiveZigmaModel();
                    zigmaModel.SetModelName(commands[2]);
                    terminalModel.UpdateActiveZigmaModel(zigmaModel);
                    break;
                case "column":
                    // perform further commands here
                    break;
                default:
                    Console.WriteLine("model - Unknow command.");
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
                    Console.WriteLine("data");
                    zigmaModel = terminalModel.GetActiveZigmaModel();
                    zigmaModel.PrintZigmaDataset(10);
                    break;
                case "alldata":
                    // perform further commands here
                    break;
                case "rows":
                    // perform further commands here
                    break;
                default:
                    Console.WriteLine("show - Unknow command.");
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
                    Console.WriteLine("raws - Unknow command.");
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
                    Console.WriteLine("column - Unknow command.");
                    Console.WriteLine("Unknow command.");
                    break;
            }
        }
    }
}
