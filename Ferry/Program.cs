using Ferry.Enums;
using Ferry.Locations;
using Ferry.Veichles;

namespace Ferry;

internal class Program
{
    static void Main(string[] args)
    {
        VechileFactory.RegisterVechile<CargoVeichile>(VechileType.Truck);
        VechileFactory.RegisterVechile<CargoVeichile>(VechileType.Bus);
        VechileFactory.RegisterVechile<GasVeichile>(VechileType.Car);
        VechileFactory.RegisterVechile<GasVeichile>(VechileType.Van);
        VechileFactory.RegisterVechile<ElectricVechile>(VechileType.Electric);
        VechileFactory.RegisterVechile<HybridVechile>(VechileType.Hybrid);


        FerryTerminal ferryTerminal = new FerryTerminal(
            new List<ILocation> 
            {
                 new Arrival
                 (
                    new List<Employee> { new Employee(), new Employee() { SalaryPercent = 0.11f} },
                    new Dictionary<VechileType, float>
                    {
                        { VechileType.Electric, 1 },
                        { VechileType.Hybrid, 2 },
                        { VechileType.Car, 3 },
                        { VechileType.Van, 4 },
                        { VechileType.Bus, 5 },
                        { VechileType.Truck, 6 }
                    } 
                  ),
                 new GasStation(),
                 new CustomInspection()
            },
            new List<Ferry> 
            { 
                new Ferry(FerryType.Large, 6, new List<VechileType> {VechileType.Bus, VechileType.Truck}),
                new Ferry(FerryType.Small, 8, new List<VechileType> {VechileType.Car, VechileType.Van}),
                new Ferry(FerryType.Eco, 10, new List<VechileType> {VechileType.Electric, VechileType.Hybrid}),
            }
        );

        while(Console.ReadKey().Key != ConsoleKey.Escape)
        {
            Vechile vechile = VechileFactory.GetRandomVechile();
            ferryTerminal.ProcessVeichile(vechile);
            Console.WriteLine("------ FINISHED PROCESSING ------\n");
        }
    }
}