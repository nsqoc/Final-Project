using System;

public class Vehicle
{
    public string Name { get; set; }
    private int Speed { get; set; }
    public static int TotalVehicles { get; private set; }

    public Vehicle(string name, int startingSpeed)
    {
        Name = name;
        Speed = startingSpeed;
        TotalVehicles++;
    }

    public virtual void Start()
    {
        Console.WriteLine("Vehicle is starting!");
    }

    public virtual void Accelerate(int increment)
    {
        Speed += increment;
        Console.WriteLine($"The new speed is {Speed}");
    }

    public int GetSpeed()
    {
        return Speed;
    }
}

public class Car : Vehicle
{
    public int FuelEfficiency { get; set; }

    public Car(string name, int startingSpeed, int fuelEfficiency) : base(name, startingSpeed)
    {
        FuelEfficiency = fuelEfficiency;
    }

    public override void Start()
    {
        Console.WriteLine("The car is starting with a smooth engine sound!");
    }
}

public class Motorcycle : Vehicle
{
    public Motorcycle(string name, int startingSpeed) : base(name, startingSpeed) { }

    public override void Start()
    {
        Console.WriteLine("The motorcycle roars to life!");
    }

    public override void Accelerate(int increment)
    {
        base.Accelerate(increment * 2);
    }
}

public class Truck : Vehicle
{
    public int CargoCapacity { get; set; }

    public Truck(string name, int startingSpeed, int cargoCapacity) : base(name, startingSpeed)
    {
        CargoCapacity = cargoCapacity;
    }

    public override void Start()
    {
        Console.WriteLine("The truck's heavy engine rumbles as it starts!");
    }
}

public class Program
{
    public static void Main()
    {
        Vehicle[] vehicles = new Vehicle[]
        {
            new Car("Car", 10, 25),
            new Motorcycle("Motorcycle", 40),
            new Truck("Truck", 15, 1000)
        };

        foreach (var vehicle in vehicles)
        {
            vehicle.Start();
        }

         

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"{vehicle.Name} speed: {vehicle.GetSpeed()}");
        }

        Console.WriteLine($"Total vehicles created: {Vehicle.TotalVehicles}");
    }
}