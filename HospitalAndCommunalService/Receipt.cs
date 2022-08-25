using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAndCommunalService
{
    class Receipt
    {
        public int Id { get; set; }
        public int Id_service { get; set; }
        public int CountUnit { get; set; }
        public int Id_tenant { get; set; }
        public int Id_adress { get; set; }
        public int Id_company { get; set; }
    }
}
