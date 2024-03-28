using Zigma.Models;

namespace Zigma.Terminal;

public class Terminal
{
    private List<string> HistoryCommands { get; set; }
    private List<ZigmaModel> Models { get; set; }
    private List<string> ModelNames {get; set; }
    private int ActiveModelPossitionInList = -1;

    public Terminal()
    {
        HistoryCommands = new();
        Models = new();
        ModelNames = new();
    }

    public void AddNewZigmaModel(ZigmaModel zModel)
    {
        Models.Add(zModel);
        ActiveModelPossitionInList++;
    }

    public string GetActiveModelName()
    {
        if (ActiveModelPossitionInList == -1)
        {
            return "noname";
        }
        else
        {
            return ModelNames[ActiveModelPossitionInList];
        }
    }

    public ZigmaModel GetActiveZigmaModel()
    {
        return Models[ActiveModelPossitionInList];
    }

    public void ChangeActiveZigmaModelByModelName(string modelName)
    {
        ActiveModelPossitionInList = ModelNames.IndexOf(modelName);
        if (ActiveModelPossitionInList == -1)
        {
            Console.WriteLine("Model with name {0} not found.", modelName);
        }
    }
}
