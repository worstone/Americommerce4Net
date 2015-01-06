using System.Collections.Generic;
using Americommerce4Net.Models;

namespace Americommerce4Net.Repositories
{
    public class RepoCustomer : BaseRepoReadWrite<Customer>
    {
        readonly static IClientReadWrite _Client = new ClientPeople().Customers;

        public RepoCustomer()
            : base(_Client, "customers") {
        }
        
        public override IRepoResponse<List<Customer>> GetAll() {
            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("id")
                .FieldValue("0")
                .Compare_GreaterThan())
                .ExpandNested("custom_fields", "addresses");
            return base.GetAll(filter);
        }


        public IRepoResponse<List<Customer>> GetCustomerNumber(string customer_number) {

            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("customer_number")
                .FieldValue(customer_number)
                .Compare_EqualTo());

            return base.RecordPaging(filter);
        }
    }
}