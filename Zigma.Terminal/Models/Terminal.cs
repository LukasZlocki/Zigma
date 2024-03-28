using Zigma.Models;

namespace Zigma.Terminal;

public class Terminal
{
    private List<string> HistoryCommands { get; set; }
    private List<ZigmaModel> Models { get; set; }
    private int ActiveModelPossitionInList = 0;

    public Terminal()
    {
        HistoryCommands = new();
        Models = new();
    }

    pu

}
