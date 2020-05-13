using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskFirst.Model;

namespace TaskFirst
{
    class DisplayData : IDisplayData
    {
        public void OutputToConsole(List<Magazine> magazines)
        {
            foreach (var mag in magazines)
            {
                Console.WriteLine(mag.Name + " Total " + "(" + mag.CountOfBusinessObjects + ")");
                mag.businessObjects.ForEach(elem =>
                {
                    Console.WriteLine(elem.Item2.ID + ": " + elem.Item1);
                });
                Console.WriteLine(String.Empty);
            }
        }

        public List<string> OutputToFile(List<Magazine> magazines)
        {
            List<string> lines = new List<string>();
            foreach (var mag in magazines)
            {
                lines.Add(mag.Name + " Total " + "(" + mag.CountOfBusinessObjects + ")");
                mag.businessObjects.ForEach(elem =>
                {
                    lines.Add(elem.Item2.ID + ": " + elem.Item1);
                });
                lines.Add(String.Empty);
            }
            return lines;
        }
    }
}
