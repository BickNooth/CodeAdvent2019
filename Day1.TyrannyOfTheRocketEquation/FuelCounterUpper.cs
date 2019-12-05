using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day1.TyrannyOfTheRocketEquation
{
    internal static class FuelCounterUpper
    {
        public static void Main(string[] args)
        {
            #region Part 1

            //Import module masses from disk
            var moduleMasses = GetModulesFromFile(Environment.GetEnvironmentVariable("ModulesCsvLocation"));
            //Get a list of SpaceCraft with fuel info
            var listOfSpacecraft = moduleMasses.Select(mass => new Spacecraft(mass)).ToList();
            //Find the total fuel required for all
            var totalFuel = listOfSpacecraft.Sum(spacecraft => spacecraft.FuelRequired);
            Console.WriteLine("Total fuel required for Santa's Elves (P1): " + totalFuel.ToString("N0"));

            #endregion

            #region Part 2

            //Get a list of SpaceCraft with fuel info, account for the weight of additional fuel
            var spacecraftAccountingFuel = moduleMasses.Select(mass => new Spacecraft(mass, true)).ToList();
            //Find the total fuel required for all
            var totalFuelWithFuel = spacecraftAccountingFuel.Sum(spacecraft => spacecraft.FuelRequired);
            Console.WriteLine("Total fuel required for Santa's Elves, accounting for additional weight (P2): " +
                              totalFuelWithFuel.ToString("N0"));

            #endregion
        }

        private static IEnumerable<int> GetModulesFromFile(string filePath)
        {
            var lines = File.ReadAllLines(filePath);

            return lines.Select(int.Parse).ToList();
        }
    }
}