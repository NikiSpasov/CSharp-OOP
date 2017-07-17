﻿using System;

public class Circle : Shape
{

    private double radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Radius
    {
        get { return radius; }
        set { this.radius = value; }
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * this.radius;
    }

    public sealed override string Draw()
    {
        return base.Draw() + "Circle";
    }
}

