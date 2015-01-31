using Americommerce4Net.Models;

namespace Americommerce4Net.Repositories
{
    public class RepoAttributeGroup : BaseRepoReadWrite<AttributeGroup>
    {
        readonly static IClientReadWrite _Client = new ClientCatalog().AttributeGroups;

        public RepoAttributeGroup()
            : base(_Client, "attribute_groups") {
        }
    }
}
