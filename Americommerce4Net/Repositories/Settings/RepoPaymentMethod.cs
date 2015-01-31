using Americommerce4Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Americommerce4Net.Repositories
{
    public class RepoPaymentMethod : BaseRepoReadWrite<Payment_Method>
    {
        readonly static IClientReadWrite _Client = new ClientSettings().PaymentMethods;

        public RepoPaymentMethod()
            : base(_Client, "payment_methods") {
        }
    }
}