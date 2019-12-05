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
            //Import module masses from disk
            var moduleMasses = GetModulesFromFile("E:/repos/code-advent/Day1.TyrannyOfTheRocketEquation/Modules.csv");
            //Get a list of SpaceCraft with fuel info
            var listOfSpacecraft = moduleMasses.Select(mass => new Spacecraft(mass)).ToList();
            //Find the total fuel required for all
            var totalFuel = listOfSpacecraft.Sum(spacecraft => spacecraft.FuelRequired);
            Console.WriteLine("Total fuel required for Santa's Elves: "+ totalFuel);
        }

        private static IEnumerable<int> GetModulesFromFile(string filePath)
        {
            var lines = File.ReadAllLines(filePath);

            return lines.Select(int.Parse).ToList();
        }
    }
}