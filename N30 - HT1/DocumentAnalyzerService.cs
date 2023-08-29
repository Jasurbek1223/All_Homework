namespace N30___HT1;

public class DocumentAnalyzerService
{
    public string Essay { get; set; }
    public int Score { get; set; }

    public async Task<int> Analyze(string essay)
    {
        Score = 100;
        Essay = essay;

        await WordsCountLess500();
        await WordsRestryingCheck();
        await CheckCapitalize();
        await CheckLowerCase();
        await CheckLongWords();

        return Score;

    }

    public async Task CheckLongWords()
    {
        var words = Essay.Split(' ');
        var count = words.Count(w => words.Length > 20);
        Score -= count * 20;
    }

    public async Task CheckLowerCase()
    {
        var sentences = Essay.Split('.', '?', '!');
        foreach (var sentence in sentences)
        {
            var words = sentence.Trim().Split();
            for (var i = 1; i < words.Length; i++)
            {
                var target = words[i];
                if (target != target.ToLower())
                    Score -= 10;
            }
        }
    }

    public async Task CheckCapitalize()
    {
        var sentences = Essay.Split('.', '?', '!');
        foreach(var sentence in sentences)
        {
            var words = sentence.Trim().Split();
            var word = words[0];
            if(word != string.Concat(word.Substring(0,1).ToUpper(), word.Substring(1).ToUpper()))
            {
                Score -= 5;
                return;
            }

        }
    }

    public async Task WordsRestryingCheck()
    {
        var words = Essay.Split(' ');
        foreach (var word in words)
        {
            var count = words.Count(w => string.Equals(w, word));

            if ((count / words.Length) * 100 >= 20)
            {
                Score -= 5;
            }

        }
    }

    public async Task WordsCountLess500()
    {
        if(Essay.Split(' ').Length < 500)
        {
            Score -= 5;
        }
    }

}
