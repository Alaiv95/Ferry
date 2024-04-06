namespace Ferry.Veichles;

public class ElectricVechile : Vechile, IEnergyUser
{
    public int EnergyAmount { get; set; } = RandomPerecentage();

    public bool IsChargeable()
    {
        return EnergyAmount < 10;
    }
}
