using Smart_Device_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Device_App
{
    public class SmartDevice
    {
        //encapulate the name prop
        private string name;

        //Public prop to access the name field
        public string Name { get { return name; } }

        //Constructor to set device name
        public SmartDevice(string name) 
        {
            this.name = name;
        }

        //Virtual method to activate the device
        //this method will be overridden by subclasses
        public virtual void Activate() 
        {
            Console.WriteLine($"{Name} is now active");
        }
    
    }

    //Light [attribute: intenstity, colour, isOn]
    public class Light : SmartDevice
    {//Child class constructor, is needed as the SmartDevice class has a constructor method
        public Light(string name) : base(name)
        {}

        public int Intensity { get; set; }
        public string Colour { get; set; }
        public bool isOn { get; private set; }

        public override void Activate()
        {
            //base.Activate(); //calling the parent method & its set behaviour
            isOn = !isOn; //toggle the state
            // ? used here is refered to as a tenary operator
            // used as a short-hand for an If-else statement 
            Console.WriteLine(isOn ? $"{Name} is now ON." : $"{Name} is now OFF."); 
        }

    }

    //Speaker [attribute: vol, bass, mode]
    public class Speaker : SmartDevice
    {
        public Speaker(string name) : base(name)
        {}

        public int Volume { get; set; }
        public int Bass { get; set; }
        public string Mode { get; set; }

        public override void Activate()
        {
            Console.WriteLine($"{Name} is now playing music in {Mode} mode");
        }
    }

    //Child Class: Thermostat [attribute: temp, condition powersaving]
    public class Thermostat : SmartDevice
    {
        public Thermostat(string name) : base(name)
        { }

        public int Temperature { get; set; }
        public string Conditiion { get; set; }
        public bool PowerSaving { get; set; }

        //H/W: override Activate Method with an If-Else statement ideal temp & a conditional statement (21 - 25  degree)

        public override void Activate()
        {
            try
            {
                Console.WriteLine("Enter the desired temperature: ");
                int temp = Convert.ToInt32(Console.ReadLine());

                if (!(temp >= 21 && temp <= 25)) // Using AND instead of OR
                {
                    throw new ArgumentOutOfRangeException("Temperature must be between 21 & 25 degrees");
                }

                Temperature = temp;
                Console.WriteLine($"{Name} set to {Temperature}°C");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
        /*
        () - Parenthesis >>>>Method Signature, Parameter List, Conditions
        {} - Curly Braces >>>>>Loop Body, Block Code to ext, Method Body
        [] - Arrays
        <> - Chevron Brackets >>>>ArrayLists, Collections 
         */




    }


