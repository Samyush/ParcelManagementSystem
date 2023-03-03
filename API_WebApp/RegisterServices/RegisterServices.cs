namespace API_WebApp.RegisterServices;

public class RegisterServices
{
    private readonly IServiceCollection _serviceCollection;

    public RegisterServices(IServiceCollection serviceCollection)
    {
        _serviceCollection = serviceCollection;
    }

    public void Services()
    {
        _serviceCollection.AddAntiforgery();
    }
}