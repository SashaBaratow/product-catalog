using productCotalog.Interfaces;

namespace productCotalog.Models
{
    public enum SortModelEnum
    { 
        NONE,
        ASC, 
        DESC
    }
    public class SortModel : IDropdownOptions
    {
        public SortModelEnum Value { get; }
        public string? DisplayName { get; }

        object IDropdownOptions.Value => Value;
    }
}
