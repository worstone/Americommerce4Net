using System.Collections.Generic;
using Americommerce4Net.Models;

namespace Americommerce4Net.Repositories
{
    public class RepoCustomerPaymentMethod : BaseRepoReadWrite<CustomerPaymentMethod>
    {
        readonly static IClientReadWrite _Client = new ClientPeople().CustomerPaymentMethods;

        public RepoCustomerPaymentMethod()
            : base(_Client, "customer_payment_methods") {
        }
    }
}
