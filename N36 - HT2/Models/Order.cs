namespace N36___HT2.Models;

public record Order(int OrderId, Customer Custommer, IEnumerable<Product> Items);

