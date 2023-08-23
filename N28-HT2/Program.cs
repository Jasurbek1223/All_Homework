using N28_HT2;
using N28_HT2.Models;


var clonableList = new ClonableList<StorageFile>
{
    new StorageFile("file1.txt", "desc1", 1024),
    new StorageFile("file2.txt", "desc2", 2048),
    new StorageFile("file3.txt", "desc3", 4096),
};

var clonedList = (ClonableList<StorageFile>)clonableList.Clone();

//update
var firstItem = clonableList.First();
firstItem.Description = "Other description ";

// elementlarini chiqarish
clonedList.ForEach(Console.WriteLine);
