namespace N30___HT1;
using System.Linq;
using System.Threading.Tasks;


internal class DocumentAnalyzer
{
    public string Content { get; set; }
    public int Result { get; set; }

    public async Task<int> Analyze(string filePath)
    {
        Result = 100;
        Content = File.ReadAllText(filePath);

        await AllWordsCount();
        //await WordsRepeatingCheck();
        await Task.Run(async () =>
        {
            await WordsRepeatingCheck();
        });
        await WordsCheckCapitalLetter();
        await WordsCheckLoweLetter();
        await WordsCheckLength();
        return Result;
    }

    //- Umumiy so'zlar soni 500 dan kam bo'lsa - 5 ball
    public async Task AllWordsCount()
    {
        if (Content.Split(' ').Length < 500)
            Result -= 5;
    }

    //- Xohlagan bitta so'z takrorlanishi umumiy so'zlar sonini 20% dan ko'pini tashkil qilsa - 5 ball
    public async Task WordsRepeatingCheck()
    {
        var words = Content.Split('.', '?', '!', ' ');

        foreach (string word in words)
        {
            var count = words.Count(x => string.Equals(x, word, StringComparison.OrdinalIgnoreCase));

            if ((count / words.Length) * 100 >= 20)
            {
                Result -= 5;
            }
        }
    }

    //- Gapda 1-so'z capital bo'lmasa - 5 ball
    public async Task WordsCheckCapitalLetter()
    {
        var checkingSentences = Content.Split('.', '?', '!');

        foreach (string word in checkingSentences)
        {
            var words = word.Trim().Split();
            var lastWord = words[0];

            if (lastWord != string.Concat(lastWord.Substring(0, 1).ToUpper(), lastWord.Substring(1).ToLower()))
            {
                Result -= 5;
                return;
            }
        }
    }

    ////- Gapda birinchi so'z bo'lmagan so'zlar faqat kichik harflar bilan yozilmagan bo'lsa - 10 ball
    public async Task WordsCheckLoweLetter()
    {
        var checkingSentences = Content.Split('?', '!', '.');

        foreach (string word in checkingSentences)
        {
            var words = word.Trim().Split();

            for (var i = 1; i < words.Length; i++)
            {
                var firstWord = words[i];

                if (firstWord != firstWord.ToLower())
                    Result -= 10;
            }
        }
    }

    ////- Gapda so'zlar uzunligi 20 dan oshib ketgan bo'lsa - 20 ball
    public async Task WordsCheckLength()
    {
        var words = Content.Split();
        var count = words.Count(word => word.Length >= 20);
        Result -= (count) * 10;
    }
}