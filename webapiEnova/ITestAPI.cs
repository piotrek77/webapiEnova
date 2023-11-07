using Soneta.Kalend;
using Soneta.Types.DynamicApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soneta.Types;

namespace webapiEnova
{
    public interface ITestAPI
    {
        private static FromTo test = new FromTo();

        [DynamicApiMethod(HttpMethods.POST, nameof(ContractImport))]
        string ContractImport(ContractImportDTO test);
    }
}
