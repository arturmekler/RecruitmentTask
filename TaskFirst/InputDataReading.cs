using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFirst
{
    public class InputDataReading : IInputDataReading
    {
        public List<string> TextContent()
        {
            string line;
            List<string> lines = new List<string>();

            try
            {
                using (StreamReader file = new StreamReader("InputData.txt"))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        if (!(line.FirstOrDefault() == '#' || String.IsNullOrEmpty(line)))
                        {
                            lines.Add(line);
                        }
                    }
                    file.Close();
                }
                return lines;
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
