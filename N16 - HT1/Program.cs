namespace N16___HT1;

internal class Program
{
    static void Main(string[] args)
    {
        Spaceship spaceship = new Spaceship("Mercedes-Benz", 120, 150);
        spaceship.DisplayStatus();
        Console.WriteLine();

        spaceship.Speed = 100;
        spaceship.DisplayStatus();
        Console.WriteLine();

        spaceship.ChangeTrajectory("Bukxara to Tashkent!");
        spaceship.DisplayStatus();
        Console.WriteLine();

        spaceship.UpdateFuel(30);
        spaceship.DisplayStatus();

    }
}