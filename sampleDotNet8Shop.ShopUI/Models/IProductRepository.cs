namespace sampleDotNet8Shop.ShopUI.Models
{
    public interface IProductRepository
    {
        PageData<Product> GetAll(int pageNumber, int pageSize);
    }
}
