using System;

public class Car //This is the Base class
{
    public Car(string brand, string model, double engineSize, string transmissionType, string colour, int numDoors, int seatCapacity)
    {
        Brand = brand;
        Model = model;
        EngineSize = engineSize;
        TransmissionType = transmissionType;
        Colour = colour;
        NumDoors = numDoors;
        SeatCapacity = seatCapacity;
    }

    //common properties of all Cars
    public string Brand { get; set; }
    public string Model { get; set; }
    public double EngineSize { get; set; }
    public string TransmissionType { get; set; }
    public string Colour { get; set; }
    public int NumDoors { get; set; }
    public int SeatCapacity { get; set; }
}

//Subclass for variations of Cars (apply inheritance)
public class Truck : Car
{
    public Truck(string brand, string model, double engineSize, string transmissionType, string colour, int numDoors, int seatCapacity) : base(brand, model, engineSize, transmissionType, colour, numDoors, seatCapacity) { }

    // Additional field
    public double CargoCapacity { get; set; }

    // Additional method
    public void LoadCargo()
    {
        Console.WriteLine("Loading cargo...");
    }

    public void UnloadCargo()
    {
        Console.WriteLine("Unloading cargo...");
    }
}

public class HatchBack : Car
{
    public HatchBack(string brand, string model, double engineSize, string transmissionType, string colour, int numDoors, int seatCapacity) : base(brand, model, engineSize, transmissionType, colour, numDoors, seatCapacity)
    {
    }

    // Additional method
    public void RaceKit()
    {
        Console.WriteLine("Installing race kit...");
    }
}

public class SUV : Car
{
    public SUV(string brand, string model, double engineSize, string transmissionType, string colour, int numDoors, int seatCapacity) : base(brand, model, engineSize, transmissionType, colour, numDoors, seatCapacity)
    {
    }

    // Additional method
    public void ModeType()
    {
        Console.WriteLine("Selecting mode type...");
    }
}

public class Sedan : Car
{
    public Sedan(string brand, string model, double engineSize, string transmissionType, string colour, int numDoors, int seatCapacity) : base(brand, model, engineSize, transmissionType, colour, numDoors, seatCapacity)
    {
    }

    // Additional method
    public void DropRoof()
    {
        Console.WriteLine("Dropping roof...");
    }
}
