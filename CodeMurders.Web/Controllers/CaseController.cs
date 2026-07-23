using CodeMurders.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeMurders.Web.Controllers;

public class CaseController : Controller
{
    public IActionResult Details()
    {
        var firstCase = new Case
        {
            Title = "The Midnight Order Service Crash",
            Status = "Active Investigation",
            IncidentTime = "02:14 AM",
            Severity = "Critical",
            Description = "The order creation service started throwing repeated exceptions " +
                          "shortly after midnight, leaving customers unable to complete their orders.",
            Objective = "Investigate the logs, commit history, and code to identify the commit " +
                        "that caused the system failure."
        };

        return View(firstCase);
    }
}
