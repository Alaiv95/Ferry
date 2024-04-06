using Ferry.Enums;
using Ferry.Veichles;

namespace Ferry;

public static class VechileFactory
{
    private static Random random = new Random();
    private static IDictionary<VechileType, Func<VechileType, Vechile>> avaliableVechiles = new Dictionary<VechileType, Func<VechileType, Vechile>>();

    public static void RegisterVechile<T>(VechileType type) where T : Vechile, new()
    {
        avaliableVechiles[type] = (type) => new T() { VechileType = type };
    }

    public static Vechile GetRandomVechile()
    {
        List<VechileType> types = avaliableVechiles.Keys.ToList();
        int index = random.Next(0, types.Count);
        VechileType randomType = types.ElementAt(index);

        return avaliableVechiles[randomType](randomType);
    }
}
