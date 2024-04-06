using Ferry.Enums;
using Ferry.Veichles;

namespace Ferry.Locations;

public class Arrival : ILocation
{
    private float _totalIncome = 0;
    private Queue<Employee> _employees;
    private IDictionary<VechileType, float> _vechileTicketTypes;

    public Arrival(List<Employee> employees, IDictionary<VechileType, float> ticketTypes)
    {
        _employees = new Queue<Employee>(employees);
        _vechileTicketTypes = ticketTypes;
    }
    public void ProcessVechile(Vechile customer)
    {
        Console.WriteLine("Processing payment for veichile of type: " + customer.TicketType());

        Employee employee = _employees.Dequeue();
        float charge = _vechileTicketTypes[customer.TicketType()];

        try
        {
            customer.Pay(charge);

            float employeePayment = charge * employee.SalaryPercent;
            float income = charge - employeePayment;

            employee.GivePayment(employeePayment);
            _totalIncome += income;

            Console.WriteLine("Payed " + employeePayment + " for employee " + employee.Name);
            Console.WriteLine("Total income: " + _totalIncome);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Payment failed " + ex.Message);
            throw new Exception("Could not process vechile");
        }
        finally
        {
            _employees.Enqueue(employee);
        }
    }
}
