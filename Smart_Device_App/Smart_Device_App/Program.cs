namespace Smart_Device_App
{
     class Program
    {
        static void Main(string[] args)
        {
            //create a list of devices
            List<SmartDevice> devices = new List<SmartDevice>
            { 
                new Light("Living Room Light"),
                new Speaker("Smart Speaker"),
                new Thermostat("Home Thermostat")
            };

            //Use a for-each & activate each device using the Activate method
            //foreach (datatype item in arrayList)
            //     { Loop Body }

            //Activate each device
            foreach (var device in devices)
            {
                Console.WriteLine($"Activating {device.Name}....");
                device.Activate();
            }
        }
    }
}
