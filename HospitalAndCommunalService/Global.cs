using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAndCommunalService
{
    class Global
    {
        public static Adress Adress { get; set; }
        public static Service Service { get; set; }
        public static Company Company { get; set; }

        public static Tenant Tenant { get; set; }

        public static Receipt Receipt { get; set; }
        public static Payment Payment { get; set; }
    }
}
