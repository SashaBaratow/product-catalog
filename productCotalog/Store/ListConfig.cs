using productCotalog.Models;

namespace productCotalog.Store
{

    public class ListConfigModel
    {
        public string? SearchTerm { get; set; } = "";
        public CategoryEnum? Category { get; set; } = null;
        public PriceModelEnum? SortOrder { get; set; } = null;
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 8;
        public int TotalCount { get; set; } = 0;
        public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);
        public int setTotalCount(int count)
        {
            TotalCount = count;
            return TotalCount;
        }
    }
}
