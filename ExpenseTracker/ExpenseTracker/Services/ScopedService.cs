namespace ExpenseTracker.Services;

public interface IScopedService
{
    string GetValue();
    void SetValue(string value);
}

public class ScopedService : IScopedService
{
    private string _value = string.Empty;

    public ScopedService()
    {
        _value = "Scoped Service";
    }

    public string GetValue()
    {
        return $"scoped: {_value}";
    }

    public void SetValue(string value)
    {
        _value = value;
    }
}
