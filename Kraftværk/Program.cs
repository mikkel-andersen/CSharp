using Kraftværk;

class Program
{
    static void Main(string[] args)
    {
        PowerPlant plant = new PowerPlant();
        plant.AddWarning(WarningToConsole);
        plant.AddWarning(AdditionalWarning);
        plant.HeatUp();
    }

    static void WarningToConsole()
    {
        Console.WriteLine("Warning: PowerPlant is overheating!");
    }

    static void AdditionalWarning()
    {
        Console.WriteLine("Additional Warning: Take immediate action!");
    }
}