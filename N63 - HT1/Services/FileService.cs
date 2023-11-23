using N63___HT1.Models;
using N63___HT1.Services.Interfaces;

namespace N63___HT1.Services;

public class FileService : IFileService
{
    public ValueTask<bool> DeleteFileAsync(string path)
    {
        throw new NotImplementedException();
    }

    public ValueTask<StorageFile> UploadFileAsync(Stream stream)
    {
        throw new NotImplementedException();
    }
}
