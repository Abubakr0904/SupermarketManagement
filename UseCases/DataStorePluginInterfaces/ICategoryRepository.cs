using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces;

public interface ICategoryRepository
{
    IEnumerable<Category> GetCategories();
    void AddCategory(Category category);
}