using Soneta.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webapiEnova
{

    [BinSerializable]
    public class PurchaseOrderDTO
    {

        public Contractor2 Contractor2 { get; set; }




        public Contractor3[] Contractor3 { get; set; }


    }
}
