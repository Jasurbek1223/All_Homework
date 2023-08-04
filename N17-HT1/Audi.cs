namespace N17_HT1;

public sealed class Audi : CarRental
{
    public Audi(int id)
        :base(id, "Audi")
    {

    }

    public override string ModelName => "Audi";
    public override double RentPricePerHour => 20;

}

