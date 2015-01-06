using System.Collections.Generic;
using Americommerce4Net.Models;

namespace Americommerce4Net.Repositories
{
    public class RepoManufacturer : BaseRepoReadWrite<Manufacturer>
    {
        readonly static IClientReadWrite _Client = new ClientCatalog().Manufacturers;

        public RepoManufacturer()
            : base(_Client, "manufacturers") {
        }
       
        public override IRepoResponse<List<Manufacturer>> GetAll() {
            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("id")
                .FieldValue("0")
                .Compare_GreaterThan());
            return base.GetAll(filter);
        }

        public IRepoResponse<List<Manufacturer>> GetAllStartingAtId(int id) {
            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("id")
                .FieldValue(id.ToString())
                .Compare_GreaterThanOrEqual());
            return base.GetAll(filter);
        }

        public IRepoResponse<List<Manufacturer>> GetByManufacturerName(string manufacturerName) {

            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("name")
                .FieldValue(manufacturerName)
                .Compare_EqualTo());

            return base.RecordPaging(filter);
        }
    }
}
