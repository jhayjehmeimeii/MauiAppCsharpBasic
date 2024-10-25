using System;

namespace MauiAppCsharpBasic.Classes
{
    public class Car
    {
        // Declare variables
        public string Model;
        public string Color; // Fixed spelling
        public double Speed;
        public double Fuel; // Change to double to match constructor
        public double TotalMile;
        public double UseFuelRate; // xxx liters per mile

        public Car(string model, double speed, double fuel)
        {
            this.Model = model;
            this.Speed = speed;
            this.Fuel = fuel;
            
        }

        public void Run(double mile)
        {
            this.TotalMile += mile;
            var use_fuel = mile * this.UseFuelRate;
            this.Fuel -= use_fuel;
        }

        public uint TimeUseeForRun(double mile)
        {
            var timeuse = mile / Speed;
            this.Run(mile);
            return Convert.ToUInt16(timeuse);
        }

        public string ShowInfo()
        {
            var info = $"Model: {this.Model}\nTotal Mile: {this.TotalMile}\nFuel: {this.Fuel}";
            return info;
        }
    }
}

