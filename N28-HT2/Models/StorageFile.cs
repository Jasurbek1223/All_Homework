﻿namespace N28_HT2.Models;

public class StorageFile : ICloneable
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Size { get; set; }

    public StorageFile(string name, string description, decimal size)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Size = size;
    }

    public object Clone()
    {
        return new StorageFile(Name, Description, Size);
    }

    public override string ToString()
    {
        return $"{Name} {Description} {Size}";
    }
}
