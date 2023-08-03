namespace N17_HT1;

internal class CarRentalManagement
{
    public List<CarRental> Cars { get; }

    public CarRentalManagement()
    {
        Cars = new List<CarRental>();
    }

    public void Add(CarRental car)
    {
        Cars.Add(car);
    }

    public  CarRental Rent(string brandName)
    {
        CarRental car = Cars.Find(c => c.BrandName == brandName && !c.IsRented);

        if (car != null)
        {
            car.IsRented = true;
            car.RentStartTime = DateTime.Now;
            Console.WriteLine($"Rented: {car}");
           // await Task.Delay(5000);
            return car;
        }

        Console.WriteLine("Uzr, hozirda ijaraga moshina yo'q");
        return null;

    }

    public void Return(CarRental car)
    {
        if (car.IsRented)
        {
            TimeSpan rentDuration = DateTime.Now - car.RentStartTime;
            int rentDurationInSeconds = (int)rentDuration.TotalSeconds;
            double rentPrice = rentDurationInSeconds * car.RentPricePerHour;

            car.Balance += rentPrice;
            car.IsRented = false;
            car.RentStartTime = DateTime.MinValue;
            Console.WriteLine($"Returned: {car}\nRent Duration: {rentDurationInSeconds}\nBalance: {car.Balance}");
        }
        else
        {
            Console.WriteLine($"{car} is not rented and cannot be returned.");
        }

    }

    public void CalculateBalance()
    {
        double totalBalance = 0;
        foreach (var car in Cars)
        {
            totalBalance += car.Balance;
        }
        Console.WriteLine($"Total Balance: {totalBalance}");
    }

}
