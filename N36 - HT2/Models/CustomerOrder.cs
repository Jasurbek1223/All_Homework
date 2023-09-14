namespace N36___HT2.Models;

public record CustomerOrder(string Name, string Email, IEnumerable<Order> Orders);
