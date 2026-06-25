namespace productCotalog.Models
{
    public enum SortModelEnum
    { 
        NONE,
        ASC, 
        DESC
    }
    public class SortModel{
        public SortModelEnum Value;
        public string? DisplayName;
    }
}
