using Zigma.Models;

namespace Zigma.Terminal.Services
{
    internal class ModelManipulator
    {
        private ZigmaModel zModel;
        private readonly CommandExtractor _commandExtractor;

        public ModelManipulator(string commandString, ZigmaModel zModel)
        {
            this.zModel = zModel;
            RunCommand(commandString);
        }

        private void RunCommand(string commandString)
        {
            string[] commands = _commandExtractor.ExtractCommands(commandString);
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



    }
}
