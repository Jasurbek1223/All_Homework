namespace N56___HT1.Services.Interfaces;

public interface IFileService
{
    string GetFileExtantions(string path);
    long GetFileSize(string filePath);
    bool DeletedFile(string filePath);
}
