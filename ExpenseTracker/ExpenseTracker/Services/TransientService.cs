namespace ExpenseTracker.Services;

public interface ITransientService
{
    string GetValue();
    void SetValue(string value);
}

public class TransientService : ITransientService
{
    private string _value = string.Empty;

    public TransientService()
    {
        _value = "Transient Service";
    }

    public string GetValue()
    {
        return $"Transient: {_value}";
    }

    public void SetValue(string value)
    {
        _value = value;
    }
}
