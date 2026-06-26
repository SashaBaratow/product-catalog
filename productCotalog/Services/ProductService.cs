using productCotalog.Models;
using productCotalog.Store;
using productCotalog.Utils;

namespace productCotalog.Services
{
    public class ProductService
    {
        private readonly ProductStore productStore;
        public List<ProductModel> productList;
        public ListConfigModel listConfigs { get; set; }

        public ProductService(ProductStore store, ListConfigModel config)  
        {
            productStore = store;
            productList = productStore.productList;
            listConfigs = config;
        }

        public List<FilterCategory> GetCategories()
        {
            return productStore.categories;
        }
        public List<PriceModel> GetPriceSortOptions()
        {
            return Enum.GetValues(typeof(PriceModelEnum)).Cast<PriceModelEnum>().Select(v => new PriceModel { Value = v, DisplayName = v.GetDisplayName() }).ToList();
        }


        public ListConfigModel GetConfigList()
        {
            return listConfigs;
        }
        public List<ProductModel> GetProducts(
        string? searchTerm,
        CategoryEnum? category,
        PriceModelEnum? sortOrder,
        int pageNumber,
        int pageSize)
        {
            
            IEnumerable<ProductModel> query = productList;

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query = query.Where(p =>
                    p.Name.ToLower().Contains(searchTerm.ToLower()));
            }

            if (category != null)
            {
                query = query.Where(p => p.Category == category);
            }
            
            query = sortOrder switch
            {
                PriceModelEnum.ASC => query.OrderBy(p => p.Price),
                PriceModelEnum.DESC => query.OrderByDescending(p => p.Price),
                _ => query
            };

  
            var filtered = query.ToList();
            var totalCount = filtered.Count;

            listConfigs.setTotalCount(totalCount);

            var items = filtered
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return items;
        }

    }
}
