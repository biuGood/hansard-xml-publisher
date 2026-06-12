using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HansardXmlPublisher.Models;
using HansardXmlPublisher.Services;

namespace HansardXmlPublisher.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly TranscriptXmlService _transcriptService;

    public HomeController(
        ILogger<HomeController> logger,
        TranscriptXmlService transcriptService)
    {
        _logger = logger;
        _transcriptService = transcriptService;
    }

    public IActionResult Index()
    {
        var model = _transcriptService.LoadTranscript();
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
        });
    }
}