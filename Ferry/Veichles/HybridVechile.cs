namespace Ferry.Veichles;

public class HybridVechile : Vechile, IEnergyUser, IGasUser
{
    public int EnergyAmount { get; set; } = RandomPerecentage();

    public int GasAmount { get; set; } = RandomPerecentage();

    public bool IsChargeable()
    {
        return EnergyAmount < 10 && GasAmount < 50;
    }

    public bool IsFillable()
    {
        return GasAmount < 10 && EnergyAmount < 50;
    }
}
