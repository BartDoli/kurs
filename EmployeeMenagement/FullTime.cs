class FullTimeContract : Contract
{
    private const double MONTHLY_RATE = 5000;
    private const int OVERTIME_RATE = (int)(MONTHLY_RATE / 60);
    public int OvertimeHours { get; set; }

    public FullTimeContract()
    {
        OvertimeHours = 0;
    }

    public override double GetSalary()
    {
        return MONTHLY_RATE + OvertimeHours * OVERTIME_RATE;
    }
}
