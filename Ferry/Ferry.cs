using Ferry.Enums;
using Ferry.Veichles;

namespace Ferry;

public class Ferry
{
    public FerryType Type { get; private set; }
    private int _capacity;
    private List<VechileType> _vechileTypes;
    private List<Vechile> _vechiles = new List<Vechile>();

    public Ferry(FerryType type, int capacity, List<VechileType> vechileTypes)
    {
        Type = type;
        _capacity = capacity;
        _vechileTypes = vechileTypes;
    }

    public bool AddVechile(Vechile vechile)
    {
        bool isAdded = false;

        if (_vechileTypes.Contains(vechile.VechileType))
        {
            _vechiles.Add(vechile);
            isAdded = true;

            if (_vechiles.Count == _capacity)
            {
                _vechiles.Clear();
            }
        }

        return isAdded;
    }

    public bool IsAcceptingVechile(Vechile vechile)
    {
        return _vechileTypes.Contains(vechile.VechileType);
    }
}
