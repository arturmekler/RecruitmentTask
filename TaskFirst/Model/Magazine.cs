using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFirst.Model
{
    public class Magazine
    {
        public string Name { get; set; }
        public List<Tuple<int, BusinessObject>> businessObjects { get; set; } = new List<Tuple<int, BusinessObject>>();
        public int CountOfBusinessObjects => businessObjects.Sum(el => el.Item1);
    }
}
