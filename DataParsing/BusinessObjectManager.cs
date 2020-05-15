using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataParsing.Model;

namespace DataParsing
{
    /// <summary>
    /// manages objects added to the list of business objects 
    /// </summary>
    class BusinessObjectManager
    {
        public static void AddBusinessObjectToList(Tuple<int, BusinessObject> tuple, 
            List<Tuple<int, BusinessObject>> businessObjectsWithCount)
        {
            if (businessObjectsWithCount.Any(businessObject => businessObject.Item2.ID == tuple.Item2.ID))
            {
                var businessObjectWithCount = businessObjectsWithCount
                    .Where(businessObject => businessObject.Item2.ID == tuple.Item2.ID)
                    .FirstOrDefault();
                var increasedCountInBusinessObject = Tuple.Create(businessObjectWithCount.Item1 + tuple.Item1, businessObjectWithCount.Item2);
                var index = businessObjectsWithCount.FindIndex(businessObject => businessObject.Item2.ID == tuple.Item2.ID);

                businessObjectsWithCount[index] = increasedCountInBusinessObject;
            }
            else
            {
                businessObjectsWithCount.Add(tuple);
            }
        }
    }
}
