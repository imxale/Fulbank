using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank
{
    class JsonData
    {
		
        public List<Json> data { get; set; }
        public Info info { get; set; }

        public class Info
        {
            public int coins_num { get; set; }
            public int time { get; set; }
        }
    }
}
