using Zigma.Models;

namespace Zigma.Terminal;

public class Terminal
{
    private List<string> HistoryCommands { get; set; }
    private List<ZigmaModel> Models { get; set; }
    private int ActiveModelPossitionInList = -1;

    public Terminal()
    {
        HistoryCommands = new();
        Models = new();
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
            return "empty";
        }
        else
        {
            return Models[ActiveModelPossitionInList].GetModelName();
        }
    }

    public ZigmaModel GetActiveZigmaModel()
    {
        return Models[ActiveModelPossitionInList];
    }

    public void ChangeActiveZigmaModelByModelName(string modelName)
    {
        ActiveModelPossitionInList = Models.FindIndex(z => z.GetModelName() == modelName);
        if (ActiveModelPossitionInList == -1)
        {
            Console.WriteLine("Model with name {0} not found.", modelName);
        }
    }

    public void RenameActiveModelName(string newName)
    {
        Models[ActiveModelPossitionInList].SetModelName(newName);
    }
}
