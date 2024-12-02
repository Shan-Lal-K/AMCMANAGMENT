using AMCMANAGMENT.Model;

namespace AMCMANAGMENT.Service.AssetCategories
{
    public interface IAssetCategoryService
    {
        Task<int> Save(AssetCategory asset);
        Task<int> Delete(int Id);
        Task<AssetCategory> Get(int Id);
        Task<List<AssetCategory>> GetAll();
    }
}
