namespace Kraftværk;

public class PowerPlant
{
    public delegate void Warning();

    private Warning? _warning;
    private Random _random = new Random();

    public void AddWarning(Warning wa)
    {
        _warning += wa;
    }

    public void HeatUp()
    {
        int temperature = _random.Next(0, 101);
        Console.WriteLine($"Current temperature: {temperature}");
        if (temperature > 50)
        {
            _warning?.Invoke();
        }
    }
}