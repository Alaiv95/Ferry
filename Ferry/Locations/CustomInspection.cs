
using Ferry.Veichles;

namespace Ferry.Locations;

public class CustomInspection : ILocation
{
    public void ProcessVechile(Vechile customer)
    {
        if (customer is CargoVeichile vechile)
        {
            CheckCargo(vechile);
        }
    }

    private void CheckCargo(CargoVeichile veichile)
    {
        Console.WriteLine("Started inspecting vechile.");

        if (veichile.CargoDoorClosed)
        {
            Console.WriteLine("Opening cargo door");
            veichile.ChangeDoorState();
        }

        veichile.ChangeDoorState();
        Console.WriteLine("Inspection finished. Closing door.");
    }
}
