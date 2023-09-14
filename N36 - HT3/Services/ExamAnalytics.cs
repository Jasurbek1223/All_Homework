namespace N36___HT3.Services;

public class ExamAnalytics
{
    private UserService _userService;
    private ExamScoreService _examScoreService;

    public ExamAnalytics(UserService userService, ExamScoreService examScoreService)
    {
        _userService = userService;
        _examScoreService = examScoreService;
    }

    public IEnumerable<(string FullName, int Score)> GetScores()
    {
        return _userService.GetUsers().Select(user =>
        {
            var fullName = $"{user.FirstName} {user.LastName}";
            var score = _examScoreService.GetExamScore(user.Id).Score;
            return (fullName, score);
        });
    }


}
