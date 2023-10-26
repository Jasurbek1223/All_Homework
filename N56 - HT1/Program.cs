using N56___HT1.Extensions;
using N56___HT1.Models;
using N56___HT1.Services;

var user1 = new User(Guid.Parse("33d0465a-e0a4-48ef-91ca-8d23d928a2a4"), "user1");
var user2 = new User(Guid.Parse("3c7435a5-bdb9-4ddf-a7d6-1057cefa6da7"), "user2");
var user3 = new User(Guid.Parse("5fd9a350-664d-4d8b-9b84-f7438c147280"), "user3");
var user4 = new User(Guid.Parse("5c080ac3-49ca-475b-a4fe-0f41e42e25d3"), "user4");
var user5 = new User(Guid.Parse("1e5fcb78-0ede-41f3-9e61-68e85d03b4a6"), "user5");
var user6 = new User(Guid.Parse("d21a4e56-ef1d-45f8-868c-2cc80137fe7d"), "user6");

user1.InitializeUserFoldersAsync();
user2.InitializeUserFoldersAsync();
user3.InitializeUserFoldersAsync();
user4.InitializeUserFoldersAsync();
user5.InitializeUserFoldersAsync();
user6.InitializeUserFoldersAsync();


var directory = new DirectoryService();
var files = new FileService();
var cleanService = new CleanService(directory, files);

var clean = await cleanService.CleanUpfile(user3);
clean.ForEach(Console.WriteLine);