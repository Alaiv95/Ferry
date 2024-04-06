using Ferry.Enums;

namespace Ferry;

public interface ITicketPayer
{
    VechileType TicketType();
    public void Pay(float amount);
}
