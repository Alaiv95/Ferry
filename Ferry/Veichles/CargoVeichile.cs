using Ferry.Enums;

namespace Ferry.Veichles;

public class CargoVeichile : Vechile, IGasUser
{
    public bool CargoDoorClosed { get; private set; } = true;
    public int GasAmount { get; set; } = RandomPerecentage();

    public void ChangeDoorState()
    {
        CargoDoorClosed = !CargoDoorClosed;
    }

    public bool IsFillable()
    {
        return GasAmount < 10;
    }
}
