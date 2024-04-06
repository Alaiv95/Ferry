using Ferry.Veichles;

namespace Ferry.Locations;

public class GasStation : ILocation
{
    public void ProcessVechile(Vechile customer)
    {
        if (customer is IGasUser veichile)
        {
            FillGas(veichile);
        }
    }

    private void FillGas(IGasUser veichile)
    {
        if (veichile.IsFillable())
        {
            Console.WriteLine($"Moved veichile with gas amount {veichile.GasAmount} to GAS station.");
            veichile.GasAmount = 100;
            Console.WriteLine("Filled veichile gas amount to " + veichile.GasAmount);
        }
        else
        {
            Console.WriteLine("Veichile gas amount is above 10 and do not require refilling");
        }
    }
}
