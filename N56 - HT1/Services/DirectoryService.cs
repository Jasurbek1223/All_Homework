using N56___HT1.Services.Interfaces;

namespace N56___HT1.Services;

public class DirectoryService : IDirectoryService
{
    public IEnumerable<string> GetListCurrentDirectories(string directoryPath)
        => Directory.EnumerateDirectories(directoryPath);

    public IEnumerable<string> GetListFiles(string filePath)
        => Directory.EnumerateFiles(filePath);
}
