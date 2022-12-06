using Microsoft.AspNetCore.Mvc;
namespace PortfolioII.Controllers;

public class PortfolioController : Controller
{
    [HttpGet("")]
    public ViewResult Home()
    {
        return View("Home");
    }

    [HttpGet("projects")]
    public ViewResult Projects()
    {
        return View("Projects");
    }
    
    [HttpGet("contact")]
    public ViewResult Contact()
    {
        return View("Contact");
    }

    // Post method
    [HttpPost("process")]
    public IActionResult Process(string fname, string email, string message)
    {    
        // Show form input in console
        Console.WriteLine($"My firstname was: {fname}");
        Console.WriteLine($"My email was: {email}");
        Console.WriteLine($"My message was: {message}");
        return RedirectToAction("Results", new {fname=fname, email=email, message=message});
    }

    [HttpGet("results")]
    public IActionResult Results(string fname, string email, string message)
    {
        // Console.WriteLine(fname);
        ViewBag.fname = fname;
        ViewBag.email = email;
        ViewBag.message = message;
        return View("Results");
    }
}