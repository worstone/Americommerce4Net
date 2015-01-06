using System.Collections.Generic;
using Americommerce4Net.Models;
using Americommerce4Net.ExtensionMethods;

namespace Americommerce4Net.Repositories
{
    public class RepoProduct : BaseRepoReadWrite<Product>
    {
        readonly static IClientReadWrite _Client = new ClientCatalog().Products;

        public RepoProduct()
            : base(_Client, "products") {
        }
        public override IRepoResponse<List<Product>> GetAll() {
            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("id")
                .FieldValue("0")
                .Compare_GreaterThan())
                .ExpandNested("custom_fields", "categories", "pricing", "pictures");
            return base.GetAll(filter);
        }
        public override IRepoResponse<List<Product>> Get_GreaterThanOrEqualTo_ModifiedDate(System.DateTime dateTime) {
            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("updated_at")
                .FieldValue(dateTime.To_ISO_8601_DateTime_Format())
                .Compare_GreaterThanOrEqual())
                .ExpandNested("custom_fields", "categories", "pricing", "pictures");

            return base.RecordPaging(filter);
        }


        public IRepoResponse<List<Product>> GetByItemNumber(string itemNumber) {

            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("item_number")
                .FieldValue(itemNumber)
                .Compare_EqualTo())
                .ExpandNested("custom_fields", "categories", "pricing", "pictures");

            return base.RecordPaging(filter);
        }
    }
}