using N36___HT3.Models;

namespace N36___HT3.Interface;

public interface IExamScoreService
{
    ExamScore Create(ExamScore examScore);
    ExamScore GetById(Guid id);
    IEnumerable<ExamScore> GetAll();
    ExamScore Update(ExamScore examScore);
    bool Delete(Guid id);
}
