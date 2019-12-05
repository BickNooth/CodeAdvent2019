using System;

namespace Day1.TyrannyOfTheRocketEquation
{
    public class Spacecraft
    {
        public int FuelRequired { get; }
        public int ModuleMass { get; }

        public Spacecraft(int moduleMass)
        {
            ModuleMass = moduleMass;
            //Take mass, divide by three, round down, minus 2
            FuelRequired = (int) Math.Floor((float)moduleMass / 3f) - 2;
        }
    }
}