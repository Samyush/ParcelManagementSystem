namespace API_WebApp.MinimalAPIs;

public class UserApIs
{
    public void RegisterApIs(WebApplication app)
    {
        app.MapGet("/hello", () => 2 + 2);
        app.MapGet("/tester1", Tester1);
        app.MapGet("/tester2", Tester2);
        app.MapGet("/tester3", Tester3);
        app.MapGet("/tester4", Tester4);
    }

    public string Tester1(string a)
    {
        return $"success + {a}";
    }

    public string Tester2()
    {
        return "success";
    }

    public string Tester3()
    {
        return "success";
    }

    public string Tester4()
    {
        return "success";
    }

    public string Tester5()
    {
        return "success";
    }
}