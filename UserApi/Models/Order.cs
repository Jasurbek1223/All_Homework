﻿namespace UserApi.Models;

public class Order
{
    public Guid Id { get; set; }
    public decimal Amount { get; set; }
    public Guid UserId { get; set; }
}
