using N36___HT3.Models;

namespace N36___HT3.Services;

public class ExamScoreService
{
    private List<ExamScore> examScores;
    public ExamScoreService()
    {
        examScores = new List<ExamScore>();
    }

    public void Create(ExamScore score)
    {
        examScores.Add(score);
    }

    public List<ExamScore> GetExamScores()
    {
        return examScores;
    }

    public ExamScore GetExamScore(Guid userId) => examScores.FirstOrDefault(score => score.UserId == userId);


    public void Update(ExamScore score)
    {
        var existExamScore = examScores.FirstOrDefault(s => s.Id == score.Id);

        if (existExamScore != null)
        {
            existExamScore.UserId = score.UserId;
            existExamScore.Score = score.Score;
        }
    }

    public void Delete(Guid Id)
    {
        var existExamScore = GetExamScore(Id);

        if(existExamScore != null)
        {
            examScores.Remove(existExamScore);
        }
    }
}
