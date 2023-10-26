using Photogram.DataLayer;
using Photogram.Services.Interfaces;

namespace Photogram.Services;

public class PostService : IPostService
{
    private readonly IDataContext _dataContext;
    private readonly IFileService _fileService;


}
