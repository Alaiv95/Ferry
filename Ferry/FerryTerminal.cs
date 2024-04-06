using Ferry.Locations;
using Ferry.Veichles;

namespace Ferry;

public class FerryTerminal
{
    private List<ILocation> _locations;
    private List<Ferry> _ferries;

    public FerryTerminal(List<ILocation> locations, List<Ferry> ferries)
    {
        _locations = locations;
        _ferries = ferries;
    }

    public void ProcessVeichile(Vechile vechile)
    {
        Console.WriteLine("Vechile arrival. Starting prcessing.");

        try
        {
            foreach (var location in _locations)
            {
                location.ProcessVechile(vechile);
            }

            LoadVeichileToFerry(vechile);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private void LoadVeichileToFerry(Vechile vechile)
    {
        Console.WriteLine("Loading vechile.");
        Ferry ferry = _ferries.Where(f => f.IsAcceptingVechile(vechile)).First();

        bool isLoaded = ferry.AddVechile(vechile);
        string loadResult = isLoaded ? "successfully loaded" : "not loaded";

        Console.WriteLine("Vechile is " + loadResult);
    }
}
