using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskFirst.Model;

namespace TaskFirst
{
    class InputDataConvert
    {
        public static void ReadTxtFile()
        {
            string line;
            int counter = 0;
            try
            {
                using (StreamReader file = new StreamReader("InputData.txt"))
                {
                    while ((line = file.ReadLine()) != null)
                    {

                        GenerateAllMaterials(line);
                        counter++;
                    }

                    file.Close();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public static void GenerateAllMaterials(string line)
        {
            if (line.FirstOrDefault() == '#' || String.IsNullOrEmpty(line))
            {

            }
            else
            {
                Console.WriteLine(line);
                var splitedLine = line.Split(';');


                BusinessObject businessObject = new BusinessObject()
                {
                    Name = splitedLine?.FirstOrDefault(),
                    ID = splitedLine?.ElementAt(1)
                };

                var magazine = splitedLine.ElementAt(2)?.Split('|');


                foreach(var m in magazine)
                {
                    var countElementInMagazine = m.Split(',').ElementAt(1);

                    Magazine mag = new Magazine()
                    {
                        Name = m.Split(',').FirstOrDefault()
                    };
                }
            }
        }
    }
}
