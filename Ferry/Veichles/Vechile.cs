using Ferry.Enums;

namespace Ferry.Veichles;

public abstract class Vechile : ITicketPayer
{
    private static Random random = new Random();
    public VechileType VechileType { get; set; }
    public VechileType TicketType() => VechileType;

    private float _money = RandomPerecentage();

    public void Pay(float amount)
    {
        if (_money < amount)
            throw new Exception("Not enough money");

        _money -= amount;
    }

    protected static int RandomPerecentage()
    {
        return random.Next(0, 100);
    }
}
