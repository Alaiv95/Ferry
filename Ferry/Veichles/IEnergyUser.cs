namespace Ferry.Veichles;

internal interface IEnergyUser
{
    public int EnergyAmount { get; set; }
    public bool IsChargeable();
}
