namespace ExpenseTracker.Services;

public interface ISingletonService
{
    string GetValue();
    void SetValue(string value);
}

public class SingletonService : ISingletonService
{
    private string _value = string.Empty;

    public SingletonService()
    {
        _value = "Singleton Service";
    }

    public string GetValue()
    {
        return $"Singleton: {_value}";
    }

    public void SetValue(string value)
    {
        _value = value;
    }
}
