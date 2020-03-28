using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\VCS\ALJ820052EngineData1.txt";

            List<PID> timeFrame = new List<PID>();
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                string[] column = line.Split('\t');

                PID newPid = new PID();
                newPid.frame = column[0];
                newPid.batteryVoltage = column[1];

                timeFrame.Add(newPid);
            }

            foreach (var timeSegment in timeFrame)
            {
                Console.WriteLine($"{timeSegment.frame} {timeSegment.batteryVoltage}");
            }
            
            Console.ReadLine();
        }
    }
}
