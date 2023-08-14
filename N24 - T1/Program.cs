using N24___T1;

List<Team> teams = new List<Team>()
        {
            new Team() { Id = 1, ClubName = "Barselona", City = "Ispaniya" },
            new Team() { Id = 2, ClubName = "Real Madrid", City = "Ispaniya" },
            new Team() { Id = 3, ClubName = "Manchester City", City = "Angliya" },
            new Team() { Id = 4, ClubName = "Bavariya", City = "Germaniya" },
            new Team() { Id = 5, ClubName = "Nasaf", City = "Uzbekistan" },
            new Team() { Id = 6, ClubName = "Zenit", City = "Rossiya" },
        };

List<Player> players = new List<Player>()
        {
            new Player() { Id = 1, Name = "Messi", TeamId = 1, Level = 94},
            new Player() { Id = 2, Name = "Ronaldu", TeamId = 2, Level = 100},
            new Player() { Id = 3, Name = "Lewandowski", TeamId = 4, Level = 89},
            new Player() { Id = 4, Name = "De Bryune", TeamId = 3, Level = 88},
            new Player() { Id = 5, Name = "Neymar", TeamId = 1, Level = 90},
            new Player() { Id = 6, Name = "Suarez", TeamId = 1, Level = 88},
            new Player() { Id = 7, Name = "Haaland", TeamId = 3, Level = 86},
            new Player() { Id = 8, Name = "Myuller", TeamId = 4, Level = 84},
            new Player() { Id = 9, Name = "Bale", TeamId = 2, Level = 82},
            new Player() { Id = 10, Name = "Ismoilov", TeamId = 5, Level = 70},
            new Player() { Id = 11, Name = "Shomurodov", TeamId = 2, Level = 78},
            new Player() { Id = 12, Name = "Cherishev", TeamId = 2, Level = 78},
            new Player() { Id = 13, Name = "Vafoyev", TeamId = 2, Level = 78},
            new Player() { Id = 14, Name = "Denisov", TeamId = 2, Level = 78},
            new Player() { Id = 15, Name = "Latipov", TeamId = 2, Level = 78},
            new Player() { Id = 16, Name = "Jesus", TeamId = 2, Level = 78},
            new Player() { Id = 17, Name = "Genynrikh", TeamId = 2, Level = 78},
            new Player() { Id = 18, Name = "Modric", TeamId = 2, Level = 99},
            new Player() { Id = 19, Name = "Modric", TeamId = 2, Level = 90},
            new Player() { Id = 20, Name = "Modric", TeamId = 2, Level = 89},
            new Player() { Id = 21, Name = "Modric", TeamId = 2, Level = 93},
            new Player() { Id = 22, Name = "Modric", TeamId = 2, Level = 97},
        };

//Select
//var result = players.Select(a=> new {Name = a.Name, Level = a.Level}).ToList();
//foreach (var player in result)
//{
//    Console.WriteLine(player.Name);
//}
//Console.WriteLine();

//Where
//var level90 = players.Where(a=> a.Level >= 90).Select(x =>x.Name).ToList();
//foreach (var player in level90)
//{
//    Console.WriteLine(player);
//}
//Console.WriteLine();


//OrderBy: 
//var level90Id = players.Where(a => a.Level >= 90).OrderBy(a=> a.Level).ToList();
//foreach (var player in level90Id)
//{
//    Console.WriteLine(player.Name + " " + player.Level + "level");
//}

//OrderByDescending: 
//var level90Id = players.Where(a => a.Level >= 90).OrderByDescending(a => a.Level).ToList();
//foreach (var player in level90Id)
//{
//    Console.WriteLine(player.Name + " " + player.Level + " level");
//}

//ThenBy: 
//var result = players.Where(a => a.Level >= 85).OrderBy(a => a.Name).ThenBy(a => a.Level).ToList();
//foreach (var player in result)
//{
//    Console.WriteLine(player.Name + " " + player.Level + " level");
//}

//ThenByDescending: 
//var result = players.Where(a => a.Level >= 85).OrderBy(a => a.Name).ThenByDescending(a => a.Level).ToList();
//foreach (var player in result)
//{
//    Console.WriteLine(player.Name + " " + player.Level + " level");
//}

//Join: 
var res = teams.Join(players,
    x => x.Id,
    p => p.TeamId,
    (x,p) => new { ClubName = x.ClubName, Name = p.Name, Level = p.Level}).OrderByDescending(k=> k.Level);
res.ToList().ForEach(x =>Console.WriteLine($"Club: {x.ClubName.PadRight(15)}\t Name: {x.Name.PadRight(15)}\t {x.Level}"));

//Aggregate: 



//GroupBy: 

//ToLookup:

//GroupJoin: 

//Reverse:

//All:

//Any: 

//Contains: 

//Distinct: 

//Except: 

//Union: 

//Intersect: 

//Count: 

//Sum:

//Average: 

//Min:

//Max:

//Take:

//Skip: 

//TakeWhile: 

//SkipWhile: 

//Concat: 

//Zip: 

//First: 

//FirstOrDefault: 

//Single: 

//SingleOrDefault: 

//ElementAt: 

//ElementAtOrDefault: 

//Last: 

//LastOrDefault: