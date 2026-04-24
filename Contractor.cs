using System;

public class Contractor
{
    // attributes
    private string name;
    private int number;
    private string startDate;

    // constructor
    public Contractor(string name, int number, string startDate)
    {
        this.name = name;
        this.number = number;
        this.startDate = startDate;
    }

    // getters and setters
    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public int GetNumber()
    {
        return number;
    }

    public void SetNumber(int number)
    {
        this.number = number;
    }

    public string GetStartDate()
    {
        return startDate;
    }

    public void SetStartDate(string startDate)
    {
        this.startDate = startDate;
    }
}