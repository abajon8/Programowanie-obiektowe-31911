using System;

namespace Lab3.Models;
public class Bike : Vehicle
{
    public Bike(double engineCapacity, string model, int year) : base(engineCapacity, model, year)
    {

    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Bike Started");
    }
}