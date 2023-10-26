
//var path = "../../../Files/salom.txt";

//FileInfo file = new FileInfo(path);

//file.Create();
//Console.WriteLine(file.FullName);
//Console.WriteLine(file.DirectoryName);
//Directory.CreateDirectory(path);

//var path1 = "../../../FilesTest";
//var path2 = "../../../Source/test.txt";

////Directory.CreateDirectory(path1);

//var text = "Hello World";

//File.WriteAllText(path2, text);
//File.AppendAllText(path2, text);
//File.AppendAllText(path2, text);
//File.WriteAllText(path2, text);

var path = "../../../Source";
DirectoryInfo dirInfo = new DirectoryInfo(path);
var str = dirInfo.CreateSubdirectory(path);
Console.WriteLine(str);

var parentPath = @"D:\.NET_new\HomeTasks\FayllarBilanIshlash";

MyLogic myLogic = new MyLogic();
myLogic.CreateDrs(parentPath, 0);

public class MyLogic
{
    public string CreateDrs(string path, int n)
    {
        if (n > 4)
            return "";
        DirectoryInfo drs = new DirectoryInfo(path);

        var dr1 = drs.CreateSubdirectory(path);
        CreateDrs(dr1.FullName, n+1);
        var dr2 = drs.CreateSubdirectory(path);
        CreateDrs(dr2.FullName, n+1);
        var dr3 = drs.CreateSubdirectory(path);
        CreateDrs(dr3.FullName, n+1);

        return "";
    }
}


//Directory.CreateDirectory(path + "/test1");