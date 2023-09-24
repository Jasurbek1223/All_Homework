namespace N43___HT1.Services.Interfaces;

public interface IPerfomanceService
{
    Task<bool> ReportPerfomanceAsync(Guid id);
}
