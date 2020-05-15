using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDisplay
{
    /// <summary>
    /// saves to OutputData.txt file
    /// </summary>
    class DataSaveToFile : IDataSaveToFile
    {
        public void SaveToFile(List<string> lines)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("OutputData.txt"))
            {
                foreach (string line in lines)
                {
                    if (!line.Contains("Second"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
        }
    }
}
