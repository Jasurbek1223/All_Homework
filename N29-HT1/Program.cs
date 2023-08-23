

var emailAddresses = new List<string>
{
    "Jasur",
    "Bobur",
    "Kamol",
    "Bunyod",
    "Azam",
    "Abdurahmon"
};


var createFileTasks = emailAddresses.Select(user => Task.Run(() =>
{
    var fileStream = File.Create($"{user.ToLower()}.docx");
    Console.WriteLine($"{user} ga fayl yaratildi");
    return fileStream;
}));

await Task.WhenAll(createFileTasks);


