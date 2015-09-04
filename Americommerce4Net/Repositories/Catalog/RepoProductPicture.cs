using Americommerce4Net.Models;

namespace Americommerce4Net.Repositories
{
    public class RepoProductPicture : BaseRepoReadWriteNested<ProductPicture>
    {
        readonly static IClientReadWrite _Client = new ClientCatalog().ProductPictures;

        public RepoProductPicture()
            : base(_Client, "pictures") {
        }
    }
}
