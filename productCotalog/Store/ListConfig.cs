using productCotalog.Models;

namespace productCotalog.Store
{

    public class ListConfigModel
    {
        public string? SearchTerm { get; set; } = "";
        public CategoryEnum? Category { get; set; } = null;
        public PriceModelEnum SortOrder { get; set; } = PriceModelEnum.ASC;
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 6;
        public int TotalCount { get; set; } = 0;
        public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);

        public void nextPage()
        {
            if (PageNumber < TotalPages)
            {
                PageNumber++;
            }
        }
        public void previousPage()
        {
            if (PageNumber > 1)
            {
                PageNumber--;
            }
        }
    }
}
