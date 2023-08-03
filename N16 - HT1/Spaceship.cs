namespace N16___HT1;

internal class Spaceship
{
    public string Name { get; init; }
    public int Fuel { get; private set; }
    public int Speed { get; set; }
    public string Trajectory { private get; set; }

    public Spaceship(string name, int fuel, int speed)
    {
        Name = name;
        Fuel = fuel;
        Speed = speed;
    }

    public void UpdateFuel(int fuel)
    {
        if (fuel < 0)
            Console.WriteLine("Yoqilg'i quyilmadi!");
        else
            Fuel += fuel;
    }

    public void ChangeTrajectory(string newTrajectory)
    {
        Console.WriteLine($"Trayektoriya o'zgartirildi:{newTrajectory}");
        Trajectory = newTrajectory;
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Fuel: {Fuel}");
        Console.WriteLine($"Speed: {Speed}");
        Console.WriteLine($"Trajectory: {Trajectory}");
    }

}
