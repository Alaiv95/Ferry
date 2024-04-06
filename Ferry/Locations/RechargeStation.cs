using Ferry.Veichles;

namespace Ferry.Locations;

public class RechargeStation : ILocation
{
    public void ProcessVechile(Vechile customer)
    {
        if (customer is IEnergyUser user)
        {
            FillEnergy(user);
        }
    }

    private void FillEnergy(IEnergyUser energyUser)
    {
        if (energyUser.IsChargeable())
        {
            Console.WriteLine("Starting charging veichile with energy amount " + energyUser.EnergyAmount);
            energyUser.EnergyAmount = 100;
            Console.WriteLine("Finished charging veichile.");
        }
    }
}
