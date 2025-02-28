using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public string Index()
    {
        return "Hello from the home controller";
    }

    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
}
