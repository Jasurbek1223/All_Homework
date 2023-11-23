using N63___HT1.Models;

namespace N63___HT1.Services.Interfaces;

public interface IStorageFileService
{
    ValueTask<StorageFile> CreateFile(string name, Guid userId);
    ValueTask<bool> DeleteFile(string path);
}
