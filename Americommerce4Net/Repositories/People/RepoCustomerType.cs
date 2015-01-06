using System.Collections.Generic;
using Americommerce4Net.Models;

namespace Americommerce4Net.Repositories
{
    public class RepoCustomerType : BaseRepoReadWrite<CustomerType>
    {
        readonly static IClientReadWrite _Client = new ClientPeople().CustomerTypes;

        public RepoCustomerType()
            : base(_Client, "customer_types") {
        }
    }
}