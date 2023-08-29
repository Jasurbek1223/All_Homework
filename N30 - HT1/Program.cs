namespace N30___HT1;


public class Program
{
    static void Main(string[] args)
    {
        string matn = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been " +
            "the industry's \r\nstandard dummy text ever since the 1500s, when an unknown printer took a galley of type" +
            " and scrambled it to make\r\na type specimen book. It has survived not only five centuries, but also the leap " +
            "into electronic typesetting, \r\nremaining essentially unchanged. It was popularised in the 1960s with the " +
            "release of Letraset sheets containing\r\nLorem Ipsum passages, and more recently with desktop publishing software" +
            " like Aldus PageMaker including versions\r\nof Lorem Ipsum.It is a long established fact that a reader will " +
            "be distracted by the readable content of a page \r\nwhen looking at its layout. The point of using Lorem Ipsum" +
            " is that it has a more-or-less normal distribution of \r\nletters, as opposed to using 'Content here, content" +
            " here', making it look like readable English. Many desktop \r\npublishing packages and web page editors now " +
            "use Lorem Ipsum as their default model text, and a search for 'lorem \r\nipsum' will uncover many web sites " +
            "still in their infancy. Various versions have evolved over the years, sometimes \r\nby accident, sometimes on " +
            "purpose (injected humour and the like).";

        DocumentAnalyzerService essayAnalyzer = new DocumentAnalyzerService();

        essayAnalyzer.Analyze(matn);
        

    }
}