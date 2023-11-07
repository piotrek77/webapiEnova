using Newtonsoft.Json;
using Soneta.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webapiEnova
{
    [BinSerializable]
    public class ContractImportDTO
    {

        public CostAllocatorInfo CostAllocatorInfo { get; set; }
        public string ContractTitle { get; set; }
        public string ContractDate { get; set; }
    }
}
