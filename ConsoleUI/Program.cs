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

            List<PID> snapshot = new List<PID>();
            List<string> lines = File.ReadLines(filePath).ToList();

            Console.WriteLine(lines);
            foreach (string line in lines)
            {
                string[] column = line.Split('\t');

                PID newPid = new PID();
                // newPid.name = column[0];
                // newPid.description = column[1];

                for (int i = 0; i < column.Length; i++)
                {
                    newPid.name = column[i];
                }
                snapshot.Add(newPid);
            }

            foreach (var pid in snapshot)
            {
                Console.WriteLine($"{pid.name}");
            }

            Console.ReadLine();
        }
        
    }
}
