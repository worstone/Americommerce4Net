using Americommerce4Net.Models;

namespace Americommerce4Net.Repositories
{
    public class RepoCustomerAddresses : BaseRepoReadWrite<CustomerType>
    {
        readonly static IClientReadWrite _Client = new ClientPeople().Addresses;

        public RepoCustomerAddresses()
            : base(_Client, "addresses") {
        }
    }
}
