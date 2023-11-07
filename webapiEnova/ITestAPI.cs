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


        [DynamicApiMethod(HttpMethods.GET, nameof(Test))]
        public string Test();


        [DynamicApiMethod(HttpMethods.POST, nameof(PostStringData),
            Summary = "Przykładowa metoda zwracająca striny podany jako parametr strValue",
            ImplementationNotes = "w paramsach dodajemy strValue, w resultacie dostaniemy ten sam string")]
        string PostStringData(string strValue);

        [DynamicApiMethod(HttpMethods.POST, nameof(Metoda1))]
        string Metoda1(PurchaseOrderDTO test);
    }
}
