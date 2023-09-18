namespace N38___HT2.Models;

public class UserAddress
{
    public int AddressId { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string State { get; set; }
    public int Number { get; set; }

    public override string ToString()
    {
        return $"AddressId : {AddressId}, Country : {Country}, State: {State}, City: {City}, Street: {Street}, Number: {Number}";
    }
}