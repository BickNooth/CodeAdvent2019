using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace Day2._1202ProgramAlarm
{
    internal static class GravityAssistComputer
    {
        public static void Main(string[] args)
        {
            var intCodes = new Intcode(Environment.GetEnvironmentVariable("InputTxtLocation"));
            
            intCodes.ProcessProgram();
        }
        
        private static IEnumerable<int> GetIntcodeFromFile(string filePath)
        {
            var fileText = File.ReadAllText(filePath);
            var itemArray = fileText.Split(',');
            return itemArray.Select(int.Parse).ToList();
        }
    }
}