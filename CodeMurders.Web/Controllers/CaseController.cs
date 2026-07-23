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

    public IActionResult Logs()
    {
        var logEntries = new List<LogEntry>
        {
            new() { Timestamp = "02:10:03 AM", Level = "INFO", Source = "OrderService", Message = "Order creation request received" },
            new() { Timestamp = "02:10:04 AM", Level = "INFO", Source = "ValidationService", Message = "Validating shipping address" },
            new() { Timestamp = "02:10:04 AM", Level = "WARNING", Source = "ValidationService", Message = "Missing shipping address" },
            new() { Timestamp = "02:10:04 AM", Level = "INFO", Source = "ValidationService", Message = "Validation process completed" },
            new() { Timestamp = "02:14:12 AM", Level = "ERROR", Source = "OrderService", Message = "NullReferenceException: Object reference not set to an instance of an object" },
            new() { Timestamp = "02:14:12 AM", Level = "ERROR", Source = "OrderService", Message = "Order creation failed" },
            new() { Timestamp = "02:14:45 AM", Level = "ERROR", Source = "OrderService", Message = "NullReferenceException: Object reference not set to an instance of an object" },
            new() { Timestamp = "02:14:45 AM", Level = "ERROR", Source = "OrderService", Message = "Order creation failed" }
        };

        return View(logEntries);
    }
}
