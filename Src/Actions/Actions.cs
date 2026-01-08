namespace OOPAdventure;

public sealed class Actions
{
    private static Actions _instance;


    public static Actions Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Actions();
            }

            return _instance;

        }
    }

    private readonly Dictionary<string, Action> _registeredActions = new();

    private Actions()
    {

    }

    public void Register(Action action)
    {
        var name = action.Name.ToLower();

        if (_registeredActions.ContainsKey(name))
        {
            _registeredActions[name] = action;
        }
        else
        {
            _registeredActions.Add(name, action);
        }

    }

    // Execute to route to the correct action
    public void Execute(string[] args)
    {
        var actionName = args[0];

        // Check if the action is registered and if not , print an error message
        if (_registeredActions.ContainsKey(actionName))
        {
            _registeredActions[actionName].Execute(args);
        }
        else
        {
            Console.WriteLine(Text.Language.ActionError);
        }
    }
}

