namespace Enums_Struct_App
{
    //declare an enum to hold the Traffic Light options
    enum TrafficLight 
    { 
        Red,
        Yellow,
        Green
    }

   class Program
    {
        static void Main(string[] args)
        {
            //to use the enum, call the enum Name & associate a value for the stored constants
            TrafficLight signal = TrafficLight.Yellow; // assigning a defualt value to make use of 

            //switch (variable)
            //{ case option:
            //      break;
            // case option:
            //     break;
            //default:  
            //}

            switch (signal)
            {
                case TrafficLight.Red:
                    Console.WriteLine("Stop!");
                    break;
                case TrafficLight.Yellow:
                    Console.WriteLine("Caution");
                    break;
                case TrafficLight.Green:
                    Console.WriteLine("Go!!!!");
                    break;
            }
        }
    }
}
