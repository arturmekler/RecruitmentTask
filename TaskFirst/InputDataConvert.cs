using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskFirst.Model;

namespace TaskFirst
{
    class InputDataConvert : IInputDataConvert
    {
        public List<Magazine> Magazines { get; set; } = new List<Magazine>();
        public List<BusinessObject> BusinessObjects { get; set; } = new List<BusinessObject>();

        public string[] Spliting(string line)
        {
            return line.Split(';');
        }

        public BusinessObject ReadBusinessObject(string[] splitedLine)
        {
            BusinessObject businessObject = new BusinessObject()
            {
                Name = splitedLine?.FirstOrDefault(),
                ID = splitedLine?.ElementAt(1)
            };
            BusinessObjects.Add(businessObject);

            return businessObject;
        }

        public void ReadMagazines(string[] splitedLine, BusinessObject businessObject)
        {
            var magazines = splitedLine.ElementAt(2)?.Split('|');

            foreach (var element in magazines)
            {
                var magazineName = element.Split(',').FirstOrDefault();
                var countElementInMagazine = element.Split(',').ElementAt(1);
                var businessObjectWithCount = Tuple.Create(Int32.Parse(countElementInMagazine), businessObject);

                if (!Magazines.Any(el => el.Name == magazineName))
                {
                    Magazine mag = new Magazine()
                    {
                        Name = magazineName
                    };
                    BusinessObjectManager.AddBusinessObjectToList(businessObjectWithCount, mag.businessObjects);
                    Magazines.Add(mag);
                }
                else
                {
                    var mag = Magazines.Where(m => m.Name == magazineName).FirstOrDefault();
                    BusinessObjectManager.AddBusinessObjectToList(businessObjectWithCount,mag.businessObjects);
                }
            }
        }
    }
}
