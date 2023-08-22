using System.ComponentModel.DataAnnotations.Schema;

namespace N28_Project.Model;

[Table("car")]
public class Car
{
    [Column("id")]
    public int Id { get; set; }
    [Column("name")]
    public string Name { get; set; }
    [Column("year")]
    public int Year { get; set; }
    [Column("person_id")]
    public int UserId { get; set; }

}
