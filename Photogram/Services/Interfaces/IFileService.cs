namespace Photogram.Services.Interfaces
{
    public interface IFileService
    {
        string FolderName { get; }

        ValueTask<string> SaveImageAsync(Guid user, IFormFile image);

        ValueTask<bool> DeletedAsync(string imageName);
    }
}
