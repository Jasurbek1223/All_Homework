using N63___HT1.Models;

namespace N63___HT1.Services.Interfaces;

public interface IFileService
{
    ValueTask<StorageFile> UploadFileAsync(Stream stream);
    ValueTask<bool> DeleteFileAsync(string path);
}
