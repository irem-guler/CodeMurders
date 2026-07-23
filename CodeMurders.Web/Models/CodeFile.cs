namespace CodeMurders.Web.Models;

public class CodeFile
{
    public string FilePath { get; set; } = string.Empty;
    public string CommitHash { get; set; } = string.Empty;
    public string CommitMessage { get; set; } = string.Empty;
    public string BeforeCode { get; set; } = string.Empty;
    public string AfterCode { get; set; } = string.Empty;
}
