using Lab3.Models;
bool run = true;
do
{
    Console.WriteLine("CAR SHOP");
    Console.Write("[1] Show all, [2] Search by year, [3] Search by model, [4] Search by engine capacity, [5] Add car, [0] Exit ");
    var input = Console.ReadKey().KeyChar;

    Console.WriteLine();

    switch (input)
    {
        case '1':
            DisplayVehicleModel();
            break;
        case '2':
            SearchByYear();
            break;
        case '3':
            SearchByModel();
            break;
        case '4':
            SearchByEngineCapacity();
            break;
        case '5':
            AddNewVehicle();
            break;
        case '0':
            run = false;
            break;
        default:
            Console.WriteLine("Invalid menu option");
            break;
    }
} while (run);

Console.WriteLine("Goodbye...");
return;

void DisplayVehicleModel()
{
    Console.WriteLine("Our vehicles:");
    foreach (var vehicle in Database.Vehicles)
    {
        Console.WriteLine(vehicle.Model);
    }
}

void SearchByYear()
{
    Console.Write("Enter year: ");
    var success = Int32.TryParse(Console.ReadLine(), out int year);
    if (!success)
    {
        Console.WriteLine("Invalid year");
        SearchByYear();
        return;
    }

    var vehicles = Database.Vehicles.Where(veh => veh.Year == year);

    if (!vehicles.Any())
    {
        Console.WriteLine("No vehicles found");
    }
    else
    {
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle.Model);
        }
    }
}

void SearchByModel()
{
    Console.Write("Enter model name (or part of it): ");
    string? input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Invalid model");
        return;
    }

    var vehicles = Database.Vehicles.Where(veh =>
        veh.Model.Contains(input, StringComparison.OrdinalIgnoreCase));


    if (!vehicles.Any())
    {
        Console.WriteLine($"No vehicles found containing '{input}'");
    }
    else
    {
        Console.WriteLine("Found vehicles:");
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($" - {vehicle.Model} ({vehicle.Year})");
        }
    }
}

void SearchByEngineCapacity()
{
    Console.Write("Enter engine capacity: ");

    var success = double.TryParse(Console.ReadLine(), out double capacity);

    if (!success)
    {
        Console.WriteLine("Invalid format");
        return;
    }

    var vehicles = Database.Vehicles.Where(veh => veh.EngineCapacity == capacity);

    if (!vehicles.Any())
    {
        Console.WriteLine($"No vehicles found with capacity: {capacity}");
    }
    else
    {
        Console.WriteLine("Found vehicles:");
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($" - {vehicle.Model} ({vehicle.Year}) - {vehicle.EngineCapacity}L");
        }
    }
}

void AddNewVehicle()
{
    Console.WriteLine("B for bike, C for car");
    var input = Console.ReadKey().KeyChar;

    if (input.ToString().ToLower() is not ("b" or "c"))
    {
        Console.WriteLine("Invalid vehicle type");
        return;
    }

    Console.Write("Enter engine capacity: ");
    var success = double.TryParse(Console.ReadLine(), out double engineCapacity);

    if (!success)
    {
        Console.WriteLine("Invalid engine capacity");
        return;
    }

    Console.Write("Enter model: ");
    string? model = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(model))
    {
        Console.WriteLine("Invalid model");
        return;
    }

    Console.Write("Enter year: ");
    success = Int32.TryParse(Console.ReadLine(), out int year);
    if (!success)
    {
        Console.WriteLine("Invalid year");
        return;
    }

    Vehicle v;

    if (input == 'C')
    {
        v = new Car(engineCapacity, model, year);
    }
    else
    {
        v = new Bike(engineCapacity, model, year);
    }

    Database.Vehicles.Add(v);
}



// Car car1 = new Car(model:"Audi", year: 2023, engineCapacity: 2.0);
// Car car2 = new Car(model:"VW", year: 1998, engineCapacity: 1.8);
// Car car3 = new Car(model:"Fiat", year: 2011, engineCapacity: 1.4);

// car1.ShowMe();
// car2.ShowMe();
// car3.ShowMe();
// var bike1 = new Bike(engineCapacity: 0.6);

// StartAnyVehicle(bike1);
// StartAnyVehicle(car2);

// void StartAnyVehicle(Vehicle vehicle)
// {
//     vehicle.Start();
// }

// Console.Write(car1.Model);