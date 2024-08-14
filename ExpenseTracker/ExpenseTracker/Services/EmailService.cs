namespace ExpenseTracker.Services;

public interface ISmsService
{
    string GetValues();
    void ChangeValues();
}

public interface IEmailService
{
    string GetValues();
    void ChangeValues();
}

public class EmailService : IEmailService
{
    private readonly ISingletonService _singletonService; // singleton1
    private readonly IScopedService _scopedService; // scoped1
    private readonly ITransientService _transientService; // transient1

    public EmailService(ISingletonService singletonService, IScopedService scopedService, ITransientService transientService)
    {
        _singletonService = singletonService;
        _scopedService = scopedService;
        _transientService = transientService;
    }

    public string GetValues()
    {
        return $"Email Service: \n{_singletonService.GetValue()}\n{_scopedService.GetValue()}\n{_transientService.GetValue()}";
    }

    public void ChangeValues()
    {
        _singletonService.SetValue($"Email Service Update");
        _scopedService.SetValue($"Email Service Update");
        _transientService.SetValue($"Email Service Update");
    }
}

public class SmsService : ISmsService
{
    private readonly ISingletonService _singletonService; // singleton1
    private readonly IScopedService _scopedService; // scoped1
    private readonly ITransientService _transientService; // transient2

    public SmsService(ISingletonService singletonService, IScopedService scopedService, ITransientService transientService)
    {
        _singletonService = singletonService;
        _scopedService = scopedService;
        _transientService = transientService;
    }

    public string GetValues()
    {
        return $"Sms Service: \n{_singletonService.GetValue()}\n{_scopedService.GetValue()}\n{_transientService.GetValue()}";
    }

    public void ChangeValues()
    {
        _singletonService.SetValue($"Sms Service Update");
        _scopedService.SetValue($"Sms Service Update");
        _transientService.SetValue($"Sms Service Update");
    }
}
