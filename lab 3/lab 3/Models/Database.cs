using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Models;
public class Database
{
    public static List<Vehicle> Vehicles { get; protected set; } = [
        new Bike(engineCapacity: 0.6, model:"Yamaha", year: 2025),
        new Bike(engineCapacity: 0.9, model:"Kawasaki", year: 2023),
        new Car(engineCapacity:2.0, model:"VW", year: 2006),
        new Car(engineCapacity:1.0, model:"Fiat", year: 2018),
        new Car(engineCapacity:1.6, model:"BMW", year: 2006)
        ];

    public void AddVehicle(Vehicle vehicle)
    {
        Vehicles.Add(vehicle);
    }
}
