namespace Ferry;

public class Employee
{
    public float Salary {  get; set; }
    public string Name { get; set; } = Guid.NewGuid().ToString();

    public float SalaryPercent { get; set; } = 0.1f;

    public void GivePayment(float amount)
    {
        Salary += amount;
    }
}
