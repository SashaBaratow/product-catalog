using productCotalog.Models;
using productCotalog.Store;

namespace productCotalog.Services
{
    public class ProductService
    {
        private readonly ProductStore productStore;
        public List<ProductModel> productList;
        public ProductService(ProductStore store)  
        {
            productStore = store;
            productList = productStore.productList;
        }

        public List<FilterCategory> GetCategories()
        {
            return productStore.categories;
        }

        public List<ProductModel> GetProducts(
        string? searchTerm,
        CategoryEnum? category,
        SortModelEnum sortOrder,
        int pageNumber,
        int pageSize)
        {
            
            IEnumerable<ProductModel> query = productList;

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query = query.Where(p =>
                    p.Name.Contains(searchTerm));
            }

            if (category != null)
            {
                query = query.Where(p => p.Category == category);
            }
            
            query = sortOrder switch
            {
                SortModelEnum.ASC => query.OrderBy(p => p.Price),
                SortModelEnum.DESC => query.OrderByDescending(p => p.Price),
                _ => query
            };

  
            var filtered = query.ToList();
            var totalCount = filtered.Count;

            var items = filtered
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return items;
        }

    }
}
