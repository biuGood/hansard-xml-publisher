using System.Xml.Linq;
using HansardXmlPublisher.Models;

namespace HansardXmlPublisher.Services;

public class TranscriptXmlService
{
    private readonly IWebHostEnvironment _environment;

    public TranscriptXmlService(IWebHostEnvironment environment)
    {
        _environment = environment;
    }

    public TranscriptViewModel LoadTranscript()
    {
        var filePath = Path.Combine(
            _environment.ContentRootPath,
            "Data",
            "transcripts.xml"
        );

        var doc = XDocument.Load(filePath);

        var model = new TranscriptViewModel
        {
            SittingDate = doc.Root?.Element("sittingDate")?.Value ?? "",
            SessionTitle = doc.Root?.Element("title")?.Value ?? "",

            Entries = doc.Root?
                .Element("proceedings")?
                .Elements("item")
                .Select(item => new TranscriptEntry
                {
                    Time = item.Element("time")?.Value ?? "",
                    Speaker = item.Element("speaker")?.Value ?? "",
                    Role = item.Element("role")?.Value ?? "",
                    Topic = item.Element("topic")?.Value ?? "",
                    Text = item.Element("text")?.Value ?? ""
                })
                .ToList() ?? new List<TranscriptEntry>()
        };

        return model;
    }
}