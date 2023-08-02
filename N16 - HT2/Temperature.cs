namespace N16___HT2;

internal class Temperature
{
    public int Expected { get; set; }
    public int Current { get; set; }

}


public class SmartHomeService
{
    private bool isActivated;

    public bool IsActivated { get { return isActivated; } }
    public string DeviceName { get; init; }
    public int ExpectedTemperature { get; set; }

    private Temperature temperature;

    public SmartHomeService(string deviceName)
    {
        DeviceName = deviceName;
        isActivated = false;
        temperature = new Temperature();
    }

    public void Activate()
    {
        isActivated = true;
        Console.WriteLine($"{DeviceName} devise ishlamoqda!");
    }

    public void SetCurrentTemperature(int currentTemperature)
    {
        temperature.Current = currentTemperature;
    }

    public void DisplayHomeTemperature()
    {
        Console.WriteLine($"Expected: {ExpectedTemperature}, Current: {temperature.Current}");
    }

}
