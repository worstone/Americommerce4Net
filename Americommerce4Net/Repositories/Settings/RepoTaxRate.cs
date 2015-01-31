using Americommerce4Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Americommerce4Net.Repositories
{
    public class RepoTaxRate : BaseRepoReadWrite<Tax_Rate>
    {
        readonly static IClientReadWrite _Client = new ClientSettings().TaxRates;

        public RepoTaxRate()
            : base(_Client, "tax_rates") {
        }
    }
}