using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;

namespace Day2._1202ProgramAlarm
{
    public class Intcode
    {
        public List<int> Ints { get; }

        public Intcode(string filePath)
        {
            var fileText = File.ReadAllText(filePath);
            var itemArray = fileText.Split(',');
            Ints = itemArray.Select(int.Parse).ToList();
        }

        public void AddOpCode(int firstNo, int secondNo, int replaceNo)
        {
            Ints[replaceNo] = Ints[firstNo] + Ints[secondNo];
        }

        public void MultiplyOpCode(int firstNo, int secondNo, int replaceNo)
        {
            Ints[replaceNo] = Ints[firstNo] * Ints[secondNo];
        }

        public void ProcessProgram()
        {
            var index = 0;
            var opCode = 0;
            while (opCode != 99)
            {
                switch (Ints[index])
                {
                    case 1:
                        AddOpCode(Ints[index+1],Ints[index+2],Ints[index+3]);
                        break;
                    case 2:
                        MultiplyOpCode(Ints[index+1],Ints[index+2],Ints[index+3]);
                        break;
                    case 99:
                        opCode = 99;
                        break;
                }

                index += 4;
            }
        }
    }
}