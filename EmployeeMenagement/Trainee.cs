class TraineeContract : Contract
{
    private const double MONTHLY_RATE = 1000;

    public override double GetSalary()
    {
        return MONTHLY_RATE;
    }
}

