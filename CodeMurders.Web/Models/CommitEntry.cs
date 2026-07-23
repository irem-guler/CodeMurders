namespace CodeMurders.Web.Models;

public class CommitEntry
{
    public string Hash { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Timestamp { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public List<string> ChangedFiles { get; set; } = new();
}
