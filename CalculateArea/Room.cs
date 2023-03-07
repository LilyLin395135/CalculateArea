namespace CalculateArea;

public class Room
{
    private readonly string _unit;
    private readonly double _area;
    private const double ConversionRate = 0.09290304;

    public double GetMeter => IsMeter() ? _area : _area / ConversionRate;

    public double GetFeet
    {
        get
        {
            if (IsFeet())
            {
                return _area;
            }

            return _area * ConversionRate;
        }
    }

    public Room(double length, double width, string unit)
    {
        _unit = unit;
        _area = length * width;
    }

    private bool IsFeet() => _unit == UnitOfArea.Feet.ToString().ToLower();

    private bool IsMeter()
    {
        return _unit == UnitOfArea.Meters.ToString().ToLower();
    }
}