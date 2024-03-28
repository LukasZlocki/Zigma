namespace Zigma.Terminal;

public class CommandExtractor
{
    internal string[] ExtractCommands (string command ) {
        string[] output = command.Split(' ');
        return output;
    }
}
