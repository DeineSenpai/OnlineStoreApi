using OnlineStore.Model;
namespace OnlineStore.Repo.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductById(int id);
        Task<List<Product>> GetProducts(int? top = null);
        Task<int> InsertProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(int id);
    }
}
