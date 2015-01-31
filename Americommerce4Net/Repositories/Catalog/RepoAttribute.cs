using Americommerce4Net.Models;

namespace Americommerce4Net.Repositories
{
    public class RepoAttribute : BaseRepoReadWrite<Attribute>
    {
        readonly static IClientReadWrite _Client = new ClientCatalog().Attributes;

        public RepoAttribute()
            : base(_Client, "attributes") {
        }
    }
}