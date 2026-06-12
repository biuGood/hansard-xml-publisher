namespace HansardXmlPublisher.Models
{
    public class TranscriptViewModel
    {
        public string SittingDate { get; set; } = "";
        public string SessionTitle { get; set; } = "";
        public List<TranscriptEntry> Entries { get; set; } = new();
    }
}