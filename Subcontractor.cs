using System;

public class Subcontractor : Contractor
{
    // new attributes
    private int shift;
    private double payRate;

    // constructor
    public Subcontractor(string name, int number, string startDate, int shift, double payRate)
        : base(name, number, startDate)
    {
        this.shift = shift;
        this.payRate = payRate;
    }

    // getters
    public int GetShift()
    {
        return shift;
    }

    public double GetPayRate()
    {
        return payRate;
    }

    // method to calculate pay
    public float CalculatePay()
    {
        float pay = (float)payRate;

        // if night shift add 3%
        if (shift == 2)
        {
            pay = pay + (pay * 0.03f);
        }

        return pay;
    }
}