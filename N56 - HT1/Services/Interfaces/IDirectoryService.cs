namespace N56___HT1.Services.Interfaces;

public interface IDirectoryService
{
    IEnumerable<string> GetListCurrentDirectories(string directoryPath);
    IEnumerable<string> GetListFiles(string directoryPath);
}
