﻿namespace N21___HT1.Interface;

public interface IDebitCard
{
    string CardNumber { get; set; }
    string BankName { get; init; }
    double Balance { get; set; }
}

