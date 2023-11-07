using Soneta.Business;
using Soneta.Kadry;
using Soneta.Types.DynamicApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webapiEnova;
using Soneta.Types;

[assembly: Service(
    typeof(ITestAPI),
    typeof(TestAPI),
    ServiceScope.Session)]

[assembly: DynamicApiController(
    typeof(ITestAPI),
    typeof(TestAPI),
    Summary = "Test")]

namespace webapiEnova
{
    public class TestAPI : ITestAPI
    {
        private Session Session { get; set; }
        public TestAPI(Session session)
        {
            Session = session;
        }
        public string ContractImport(ContractImportDTO contract)
        {
            if (contract == null)
                throw new Exception("contract = null");
            if (contract.CostAllocatorInfo == null)
                throw new Exception("contract.CostAllocatorInfo1 = null");
            if (contract.CostAllocatorInfo.ContractId == null)
                throw new Exception("contract.CostAllocatorInfo1.ContractId = null");

            return "";
        }
    }
}