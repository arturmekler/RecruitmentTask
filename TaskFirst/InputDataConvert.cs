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
        List<Magazine> magazines = new List<Magazine>();

        public void ReadTxtFile()
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

        public void GenerateAllMaterials(string line)
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
                    var name = m.Split(',').FirstOrDefault();
                    var countElementInMagazine = m.Split(',').ElementAt(1);
                    var tuple = Tuple.Create(Int32.Parse(countElementInMagazine), businessObject);

                    if (!magazines.Any(el => el.Name == name))
                    {
                        Magazine mag = new Magazine()
                        {
                            Name = name
                        };
                        mag.AddBusinessObjectToList(tuple);
                        magazines.Add(mag);
                    }
                    else
                    {
                        magazines.Where(asd => asd.Name == name).FirstOrDefault().AddBusinessObjectToList(tuple);
                    }
                }           
            }
        }
    }
}
