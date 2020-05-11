using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFirst.Model
{
    class Magazine
    {
        public string Name { get; set; }
        public List<BusinessObject> businessObjects;
        public int CountOfBusinessObjects { get; set; }
    }
}
