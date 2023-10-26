using N56___HT1.Services;

internal class CleanUpService
{
    private DirectoryService directory;
    private FileService files;

    public CleanUpService(DirectoryService directory, FileService files)
    {
        this.directory = directory;
        this.files = files;
    }
}