using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskFirst.Model;

namespace TaskFirst
{
    class BusinessObjectManager
    {
        public static void AddBusinessObjectToList(Tuple<int, BusinessObject> tuple, 
            List<Tuple<int, BusinessObject>> businessObjects)
        {
            businessObjects.Add(tuple);
        }
    }
}
