using System.Collections.Generic;
using Americommerce4Net.Resources;
using Americommerce4Net.ExtensionMethods;

namespace Americommerce4Net.Clients
{
    public class BaseWithNestedClient : BaseNotNestedClient
    {
        protected internal BaseWithNestedClient(IRestEngine restEngine)
            : base(restEngine) { }

        public IClientResponse<dynamic> Get(int recordId, FilterSingleNested filter) {
            return base.Get(recordId, filter, ResourceName);
        }

        public IClientResponse<dynamic> Get(int recordId, string nestedResource, FilterNestedOnly filter) {
            return base.Get(recordId, nestedResource, filter, ResourceName);
        }
    }
}