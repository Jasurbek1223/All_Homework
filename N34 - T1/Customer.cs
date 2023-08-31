namespace N34___T1;

public class Customer
{
    public int Id { get; set; }
    public int Count { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }

    public Customer(int id, int count, decimal amount, DateTime date)
    {
        Id = id;
        Count = count;
        Amount = amount;
        Date = date;
    }

}