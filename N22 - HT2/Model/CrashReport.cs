using N22___HT2.Interface;

namespace N22___HT2.Model;

public class CrashReport : IReview
{
    public int Id { get; set; }
    public int Star { get; set; }
    public string Message { get; set; }
    public string ScreenshotPath { get; set; }
}
