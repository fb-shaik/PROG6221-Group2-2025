using System;

namespace Class_Objects_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example usage of the classes
            Car car1 = new Car("Toyota", "Corolla", 1.8, "Automatic", "Red", 4, 5);
            Truck truck1 = new Truck("Ford", "F150", 5.0, "Automatic", "Black", 4, 3);
            HatchBack hatchBack1 = new HatchBack("Volkswagen", "Golf", 2.0, "Manual", "Blue", 5, 5);
            SUV suv1 = new SUV("Honda", "CRV", 2.4, "Automatic", "Silver", 4, 5);
            Sedan sedan1 = new Sedan("BMW", "3 Series", 2.0, "Automatic", "White", 4, 5);

            // Accessing properties
            Console.WriteLine($"Car1: {car1.Brand}, {car1.Model}");
            Console.WriteLine($"Truck1: {truck1.Brand}, {truck1.Model}, Cargo Capacity: {truck1.CargoCapacity} tons");
            Console.WriteLine($"HatchBack1: {hatchBack1.Brand}, {hatchBack1.Model}");
            Console.WriteLine($"SUV1: {suv1.Brand}, {suv1.Model}");
            Console.WriteLine($"Sedan1: {sedan1.Brand}, {sedan1.Model}");

            // Additional methods/behaviors
            truck1.LoadCargo();
            truck1.UnloadCargo();
            hatchBack1.RaceKit();
            suv1.ModeType();
            sedan1.DropRoof();
        }
    }
}