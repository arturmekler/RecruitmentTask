using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFirst.Model
{
    // magazyn musi wiedziec o:
    // elementy jakie trzyma oraz ich ilosc

        // elementy sa trzymane w Lis
    class Magazine
    {
        public string Name { get; set; }
        public List<Tuple<int, BusinessObject>> businessObjects = new List<Tuple<int, BusinessObject>>();
        public int CountOfBusinessObjects
        {
            get
            {
                return businessObjects.Sum(el => el.Item1);
            }
        }

        public void AddBusinessObjectToList(Tuple<int, BusinessObject> tuple)
        {
            businessObjects.Add(tuple);
        }
    }
}
