using Americommerce4Net.Models;

namespace Americommerce4Net.Repositories
{
    public class RepoCategory : BaseRepoReadWrite<Category>
    {
        readonly static IClientReadWrite _Client = new ClientCatalog().Categories;

        public RepoCategory()
            : base(_Client, "categories") {
        }
    }
}
