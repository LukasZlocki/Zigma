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
                    // ToDo : perform further commands here
                    break;
                case "show":
                    Console.WriteLine("show");
                    ProcessCommandOnLevel2_model_show(commands, ref terminalModel);
                    break;
                case "activate":
                    terminalModel.ChangeActiveZigmaModelByModelName(commands[2]);
                    break;
                case "rename":
                    zigmaModel = terminalModel.GetActiveZigmaModel();
                    zigmaModel.SetModelName(commands[2]);
                    terminalModel.UpdateActiveZigmaModel(zigmaModel);
                    break;
                case "column":
                    // ToDo : perform further commands here
                    Console.WriteLine("column");
                    ProcessCommandOnLevel2_model_column(commands, ref terminalModel);
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
                    Console.WriteLine("data");
                    terminalModel.ShowListOfModels();
                    break;
                case "data":
                    Console.WriteLine("data");
                    zigmaModel = terminalModel.GetActiveZigmaModel();
                    zigmaModel.PrintZigmaDataset(10);
                    break;
                case "alldata":
                    Console.WriteLine("alldata");
                    zigmaModel = terminalModel.GetActiveZigmaModel();
                    int _rowQuantity = zigmaModel.GetDatasetRowQuantity();
                    zigmaModel.PrintZigmaDataset(_rowQuantity);
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
                    Console.WriteLine("remove");
                    ProcessCommandOnLevel3_model_column_remove(commands, ref terminalModel);
                    break;
                case "switch":
                    Console.WriteLine("switch");
                    ProcessCommandOnLevel3_model_column_switch(commands, ref terminalModel);
                    break;
                default:
                    Console.WriteLine("column - Unknow command.");
                    Console.WriteLine("Unknow command.");
                    break;
            }
        }

        private void ProcessCommandOnLevel3_model_column_remove(string[] commands, ref Terminal terminalModel)
        {

            if (int.TryParse(commands[3], out int intValue))
            {
                switch (commands[3])
                {
                    default:
                        Console.WriteLine("" + commands[3]);
                        zigmaModel = terminalModel.GetActiveZigmaModel();
                        int _columnNumber = int.Parse(commands[3]);
                        zigmaModel = zigmaManipulator.transformationTool.ColumnRemove(zigmaModel, _columnNumber);
                        terminalModel.UpdateActiveZigmaModel(zigmaModel);
                        break;
                }

            }
            else
            {
                switch (commands[3])
                {
                    case "recurrence":
                        Console.WriteLine("recurrence");
                        Console.WriteLine("" + commands[3]);
                        zigmaModel = terminalModel.GetActiveZigmaModel();
                        int _columnRecurrenceNumber = int.Parse(commands[3]);
                        zigmaModel = zigmaManipulator.transformationTool.RemoveRecurrenceData(zigmaModel, _columnRecurrenceNumber);
                        terminalModel.UpdateActiveZigmaModel(zigmaModel);
                        break;
                    default:
                        Console.WriteLine("remove - Unknow command.");
                        Console.WriteLine("Unknow command.");
                        break;
                }
            }
        }


        private void ProcessCommandOnLevel3_model_column_switch(string[] commands, ref Terminal terminalModel)
        {
            Console.WriteLine("" + commands[3]);
            Console.WriteLine("" + commands[4]);
            zigmaModel = terminalModel.GetActiveZigmaModel();
            // ToDo : Write switching columns zigma library and implement here ...
            // implementation draft:
            // zigmaModel = zigmaManipulator.transformationTool.ColumnSwitch(commands[3], commands[4]);
        
        }
    }
}
