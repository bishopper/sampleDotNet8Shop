namespace sampleDotNet8Shop.ShopUI.Models
{
    public class EFProductRepository : IProductRepository
    {
        private readonly ShopDbContext shopDbContext;

        public EFProductRepository(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }
        public PageData<Product> GetAll(int pageNumber, int pageSize)
        {
            var result = new PageData<Product>
            {
                PageInfo = new PageInfo
                {
                    PageSize = pageSize,
                    PageNumber = pageNumber,
                }
            };
            result.Data = shopDbContext.Products.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            result.PageInfo.TotalCount = shopDbContext.Products.Count();
            return result;
        }
    }
}
