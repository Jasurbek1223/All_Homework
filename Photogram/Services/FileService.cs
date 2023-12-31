﻿using Photogram.Services.Interfaces;

namespace Photogram.Services;

public class FileService : IFileService
{
    private readonly string _folderName = "images";
    private readonly string _basePath;

    public FileService(IWebHostEnvironment webHost)
    {
        _basePath = webHost.WebRootPath;
    }

    public string FolderName => _folderName;

    public async ValueTask<bool> DeletedAsync(string imageName)
    {
        var path = Path.Combine(_basePath, _folderName, imageName);

        if(!File.Exists(path))
            return false;

        File.Delete(path);

        return true;
    }

    public ValueTask<string> SaveImageAsync(Guid user, IFormFile image)
    {
        throw new NotImplementedException();
    }

    //public ValueTask<string> SaveImageAsync(Guid user, IFormFile image)
    //{
    //    var folderPath = Path.Combine(_basePath, _folderName);

    //    if (!Directory.Exists(_basePath))
    //    {
    //        Directory.CreateDirectory(_basePath);
    //    }
    //    if (!Directory.Exists(folderPath))
    //    {
    //        Directory.CreateDirectory(folderPath);
    //    }

    //    var imageName = Path.Combine(folderPath, Guid.NewGuid().ToString() + Path.GetExtension(image.FileName));
    //}
}
