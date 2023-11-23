namespace N63___HT1.Models;

public class StorageFile
{
    public Guid Id { get; set; }
    public string FileName { get; set; }
    public DateTime UploadTime { get; set; }
    public Guid UserId { get; set; }
}
