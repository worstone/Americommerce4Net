using System;
using System.Collections.Generic;
using Americommerce4Net.Models;
using Americommerce4Net.ExtensionMethods;

namespace Americommerce4Net.Repositories
{
    public class RepoOrder : BaseRepoReadWrite<Order>
    {

        readonly static IClientReadWrite _Client = new ClientOrderProc().Orders;

        public RepoOrder()
            : base(_Client, "orders") {
        }
        
        public override IRepoResponse<List<Order>> GetAll() {
            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("id")
                .FieldValue("0")
                .Compare_GreaterThanOrEqual())
                .ExpandNested("items", "payments", "shipments", "custom_fields");

            return base.GetAll(filter);
        }

        public override IRepoResponse<List<Order>> Get_GreaterThanOrEqualTo_ModifiedDate(DateTime dateTime) {
            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("updated_at")
                .FieldValue(dateTime.To_ISO_8601_DateTime_Format())
                .Compare_GreaterThanOrEqual())
                .ExpandNested("items", "payments", "shipments", "custom_fields");

            return base.RecordPaging(filter);
        }

        public IRepoResponse<List<Order>> GetByOrderNumber(string order_number) {

            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("order_number")
                .FieldValue(order_number)
                .Compare_EqualTo());

            return base.RecordPaging(filter);
        }
    }
}