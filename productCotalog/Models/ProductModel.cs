using productCotalog.Interfaces;

namespace productCotalog.Models
{
    public class ProductModel
    {
        public int Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public decimal Price { get; init; }
        public CategoryEnum Category { get; init; } = CategoryEnum.HOME;
        public string ImageUrl { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
    }

    public enum CategoryEnum
    {
        [System.ComponentModel.DataAnnotations.Display(Name = "Дом и сад")]
        HOME,
        [System.ComponentModel.DataAnnotations.Display(Name = "Электроника")]
        ELECTRONICS,
        [System.ComponentModel.DataAnnotations.Display(Name = "Одежда")]
        CLOTHES,
        [System.ComponentModel.DataAnnotations.Display(Name = "Спорт")]
        SPORT,
        [System.ComponentModel.DataAnnotations.Display(Name = "Книги")]
        BOOKS,
        [System.ComponentModel.DataAnnotations.Display(Name = "Игрушки")]
        TOYS
    }
    public class FilterCategory :  IDropdownOptions
    {
        public CategoryEnum Value { get; init; }
        public string DisplayName { get; init; } = string.Empty;
        object IDropdownOptions.Value => Value;
    }
}
