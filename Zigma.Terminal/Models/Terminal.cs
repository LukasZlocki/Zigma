using Zigma.Models;

namespace Zigma.Terminal;

public class Terminal
{
    List<string> HistoryCommands { get; set; }
    List<ZigmaModel> Models { get; set; }
    int ActiveModelPossitionInList { get; set; }

    public Terminal()
    {
        HistoryCommands = new();
        Models = new();
    }

}
