using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSUMEAPI
{
    public class employee
    {
        public int id { get; set; }
        public string employee_name { get; set; }
        public decimal employee_salary { get; set; }
        public int employee_age { get; set; }
        public string profile_image { get; set; }

        //---API EMPLOYEE--//


        public string name { get; set; }

        public decimal salary { get; set; }
        public int age { get; set; }
        public string profile { get; set; }

        public string document_number { get; set; }

        public string email { get; set; }

        public string address { get; set; }
    }
}
