using System;

namespace ClassExecise
{
    class Program
    {
        static void Main(string[] args)
        {
            Fordon flyingVehicle = new Fordon(4, 2, "silver", "airborne vehicle", "combustion engine");
            Fordon armorVehicle = new Fordon(4, 4, "black", "armored vehicle", "combustion engine");
            Fordon elScooter = new Fordon(2, 0, "white", "scooter", "electric motor");

            Console.WriteLine(flyingVehicle.Describe());
            Console.WriteLine(armorVehicle.Describe());
            Console.WriteLine(elScooter.Describe());
        }
    }

    class Fordon
    {
        public int wheels;
        public string color;
        public int doors;
        public string driveTrain;
        public string type;

        public Fordon(int vehWheels, int vehDoors, string vehColor, string vehType, string vehDriveTrain)
        {
            wheels = vehWheels;
            color = vehColor;
            doors = vehDoors;
            type = vehType;
            driveTrain = vehDriveTrain;
        }

        public string Describe()
        {
            return $"This vehicle is a {color} {type}, has {doors} doors and {wheels} wheels and a {driveTrain}.";
        }

    }
}
