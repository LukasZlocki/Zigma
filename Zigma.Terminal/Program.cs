using Zigma.Terminal;
using Zigma.Terminal.Services;

Terminal TerminalModel = new();
CommandExtractor ExtractCommand = new();
ModelManipulator ManipulateModel;

string Command="";

Console.Clear();
Console.WriteLine("Zigma data modeler.");
Console.WriteLine("");

do
{
    Console.Write("{0} -->> ", TerminalModel.GetActiveModelName());
    Command = Console.ReadLine();
    string[] CommandWords = ExtractCommand.ExtractCommands(Command);
    ManipulateModel = new(CommandWords, ref TerminalModel);
} while(!(Command == "exit"));

Console.WriteLine("Zigma exited.");