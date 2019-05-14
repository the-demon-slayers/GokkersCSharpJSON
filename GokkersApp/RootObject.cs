using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokkersApp
{
    class RootObject
    {
        
        public string type { get; set; }
        public string name { get; set; }
        public string database { get; set; }
        public List<Datum> data { get; set; }
    }
}
