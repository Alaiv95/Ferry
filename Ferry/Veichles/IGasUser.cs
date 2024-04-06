namespace Ferry.Veichles;

public interface IGasUser
{
    public int GasAmount { get; set; }
    public bool IsFillable();
}
