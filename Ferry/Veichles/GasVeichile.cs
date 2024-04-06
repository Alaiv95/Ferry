using Ferry.Enums;

namespace Ferry.Veichles;

public class GasVeichile : Vechile, IGasUser
{
    private const int GasFillBreakpoint = 10;
    public int GasAmount { get; set; } = RandomPerecentage();
    public bool IsFillable() => GasAmount < GasFillBreakpoint;
}
