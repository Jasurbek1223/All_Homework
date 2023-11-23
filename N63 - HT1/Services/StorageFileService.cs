using N63___HT1.Models;
using N63___HT1.Services.Interfaces;

namespace N63___HT1.Services;

public class StorageFileService : IStorageFileService
{
    public ValueTask<StorageFile> CreateFile(string name, Guid userId)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> DeleteFile(string path)
    {
        throw new NotImplementedException();
    }
}
