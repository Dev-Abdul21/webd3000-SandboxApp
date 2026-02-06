using Microsoft.AspNetCore.Mvc;
using SandboxApp.Models;

namespace SandboxApp.Controllers;

public class FormsController : Controller
{
    public IActionResult ContactForm()
    {
        return View("ContactForm");
    }

    // POST request

    // [HttpPost]
    // public IActionResult ContactForm(string FirstName, string LastName)
    // {
    //     string message = $"Welcome to my web app {FirstName} {LastName}";
    //     ViewData["Message"] = message;
    //     return View();
    // }
    // [HttpPost]
    // public IActionResult ContactForm(Person person)
    // {
    //     string message = $"Welcome to my web app {person.FirstName} {person.LastName}";
    //     ViewData["Message"] = message;
    //     return View();
    // }

    [HttpPost]
    public IActionResult ContactForm([Bind("FirstName")] Person person)
    {
        string message = $"Welcome to my web app {person.FirstName} {person.LastName}";
        ViewData["Message"] = message;
        return View();
    }
}
