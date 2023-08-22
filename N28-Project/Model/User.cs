using System.ComponentModel.DataAnnotations.Schema;

namespace N28_Project.Model;

[Table("person")]
public class User
{
    [Column("id")]
    public int Id { get; set; }
    [Column("name")]
    public string Name { get; set; }
    [Column("age")]
    public int Age { get; set; }

}

