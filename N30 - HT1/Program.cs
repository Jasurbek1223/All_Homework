namespace N30___HT1;

public class Program
{
    static async Task Main(string[] args)
    {
        string directoryPath = @"D:\.NET_new\HomeTasks\N30 - HT1\";

        string matn = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut 
labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex
ea commodo consequat.";


        for (int i = 1; i <= 10; i++)
        {
            DocumentAnalyzer analyzer = new DocumentAnalyzer();

            string filePath = Path.Combine(directoryPath, $"file{i}.txt");

            try
            {
                // Write text to the file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    await writer.WriteAsync(matn);
                }

                // Read the text from the file
                int score = await analyzer.Analyze(filePath);
                Console.WriteLine($"File: {filePath}, Score: {score}");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


