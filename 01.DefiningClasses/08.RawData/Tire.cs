using System;

public class Tire
{
    private double[] fourTiresPressure;

    public Tire(double[] fourTiresPressure)
    {
        this.fourTiresPressure = fourTiresPressure;
    }
    public double[] FourTiresPressure
    {
        get { return fourTiresPressure; }
        set {
            if (fourTiresPressure.Length != 4)
            {
                throw new ArgumentException("Tires must be exatc 4!");
            }
            fourTiresPressure = value;
        }
    }
}
