using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSUMEAPI
{
    public class Response
    {
        public string Status { get; set; }

        public List<employee> Data { get; set; }
    }
}
