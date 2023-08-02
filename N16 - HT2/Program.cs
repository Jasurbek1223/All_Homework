namespace N16___HT2;

internal class Program
{
    static void Main(string[] args)
    {
        SmartHomeService smartHome = new SmartHomeService("Artel");

        smartHome.ExpectedTemperature = 12;
        smartHome.SetCurrentTemperature(20);
        smartHome.Activate();
        smartHome.DisplayHomeTemperature();

        smartHome.SetCurrentTemperature(30);
        smartHome.DisplayHomeTemperature();

        smartHome.SetCurrentTemperature(20);
        smartHome.DisplayHomeTemperature();

        smartHome.ExpectedTemperature = 25;
        smartHome.SetCurrentTemperature(21);
        smartHome.DisplayHomeTemperature();
    }
}   