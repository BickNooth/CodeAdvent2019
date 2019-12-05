using System;

namespace Day1.TyrannyOfTheRocketEquation
{
    public class Spacecraft
    {
        public int FuelRequired { get; set; }
        public int ModuleMass { get; }
        

        public Spacecraft(int moduleMass)
        {
            ModuleMass = moduleMass;
            //Take mass, divide by three, round down, minus 2
            FuelRequired = (int) Math.Floor((float)moduleMass / 3f) - 2;
        }

        public Spacecraft(int moduleMass, bool accountForFuelWeight)
        {
            ModuleMass = moduleMass;

            var fuelRequired = 0;
            var remainderAmount = moduleMass;
            var remainder = true;
            while (remainder)
            {
                var fuel = CalculateFuelForMass(remainderAmount);
                if (fuel > 0)
                {
                    fuelRequired += fuel;
                    remainderAmount = fuel;
                }
                else
                {
                    remainder = false;
                }
            }

            FuelRequired = fuelRequired;
        }

        private int CalculateFuelForMass(int weight)
        {
            return (int) Math.Floor((float)weight / 3f) - 2;
        }
    }
}