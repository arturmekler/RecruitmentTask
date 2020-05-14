using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParsing
{
    public class InputDataReadingFromConsole : IInputDataReading
    {
        public List<string> TextContent()
        {
            List<string> lines = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter input:");
                string line = Console.ReadLine();

                if (!(line.FirstOrDefault() == '#' 
                    || String.IsNullOrEmpty(line)
                    || line=="exit"))
                {
                    lines.Add(line);
                }
                if (line == "exit")
                {
                    break;
                }
            }
            return lines;
        }
    }
}
