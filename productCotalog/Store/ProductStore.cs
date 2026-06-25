using productCotalog.Models;

namespace productCotalog.Store
{
    public class ProductStore
    {
        public readonly List<ProductModel> productList = new List<ProductModel>()
        {
            new ProductModel { Id = 1, Name = "Ноутбук ASUS VivoBook", Price = 54990m, Category = CategoryEnum.ELECTRONICS, ImageUrl = "https://picsum.photos/seed/p1/300/200", Description = "Лёгкий и производительный ноутбук для работы и учёбы." },
            new ProductModel { Id = 2, Name = "Смартфон Pixel Lite", Price = 32990m, Category = CategoryEnum.ELECTRONICS, ImageUrl = "https://picsum.photos/seed/p2/300/200", Description = "Современный смартфон с хорошей камерой и долгим автономным временем работы." },
            new ProductModel { Id = 3, Name = "Беспроводные наушники", Price = 4990m, Category = CategoryEnum.ELECTRONICS, ImageUrl = "https://picsum.photos/seed/p3/300/200", Description = "Наушники с шумоподавлением и до 20 часов автономной работы." },
            new ProductModel { Id = 4, Name = "Умные часы FitTrack", Price = 8990m, Category = CategoryEnum.ELECTRONICS, ImageUrl = "https://picsum.photos/seed/p4/300/200", Description = "Следят за пульсом, сном и активностью, уведомления с телефона." },
            new ProductModel { Id = 5, Name = "Зимняя куртка", Price = 12990m, Category = CategoryEnum.CLOTHES, ImageUrl = "https://picsum.photos/seed/p5/300/200", Description = "Тёплая куртка с водоотталкивающей пропиткой для холодной погоды." },
            new ProductModel { Id = 6, Name = "Кроссовки беговые", Price = 6490m, Category = CategoryEnum.CLOTHES, ImageUrl = "https://picsum.photos/seed/p6/300/200", Description = "Лёгкие кроссовки с амортизацией для бега и повседневной носки." },
            new ProductModel { Id = 7, Name = "Футболка хлопковая", Price = 1290m, Category = CategoryEnum.CLOTHES, ImageUrl = "https://picsum.photos/seed/p7/300/200", Description = "Базовая футболка из 100% хлопка, разные размеры и цвета." },
            new ProductModel { Id = 8, Name = "Джинсы классические", Price = 3490m, Category = CategoryEnum.CLOTHES, ImageUrl = "https://picsum.photos/seed/p8/300/200", Description = "Прямой крой, плотная джинсовая ткань, подходят на каждый день." },
            new ProductModel { Id = 9, Name = "Война и мир (роман)", Price = 890m, Category = CategoryEnum.BOOKS, ImageUrl = "https://picsum.photos/seed/p9/300/200", Description = "Классический роман Л. Н. Толстого в твёрдом переплёте." },
            new ProductModel { Id = 10, Name = "Учебник по программированию на C#", Price = 1590m, Category = CategoryEnum.BOOKS, ImageUrl = "https://picsum.photos/seed/p10/300/200", Description = "Подробное руководство по языку C# для начинающих и не только." },
            new ProductModel { Id = 11, Name = "Детектив \"Тихий свидетель\"", Price = 650m, Category = CategoryEnum.BOOKS, ImageUrl = "https://picsum.photos/seed/p11/300/200", Description = "Захватывающий детектив с неожиданной развязкой." },
            new ProductModel { Id = 12, Name = "Книга рецептов \"Домашняя кухня\"", Price = 990m, Category = CategoryEnum.BOOKS, ImageUrl = "https://picsum.photos/seed/p12/300/200", Description = "Более 100 простых и вкусных рецептов на каждый день." },
            new ProductModel { Id = 13, Name = "Горный велосипед", Price = 24990m, Category = CategoryEnum.SPORT, ImageUrl = "https://picsum.photos/seed/p13/300/200", Description = "Надёжный велосипед с амортизационной вилкой для бездорожья." },
            new ProductModel { Id = 14, Name = "Гантели разборные 2x10 кг", Price = 3990m, Category = CategoryEnum.SPORT, ImageUrl = "https://picsum.photos/seed/p14/300/200", Description = "Набор разборных гантелей для домашних тренировок." },
            new ProductModel { Id = 15, Name = "Коврик для йоги", Price = 1490m, Category = CategoryEnum.SPORT, ImageUrl = "https://picsum.photos/seed/p15/300/200", Description = "Нескользящий коврик толщиной 6 мм для йоги и фитнеса." },
            new ProductModel { Id = 16, Name = "Футбольный мяч", Price = 1990m, Category = CategoryEnum.SPORT, ImageUrl = "https://picsum.photos/seed/p16/300/200", Description = "Мяч размера 5 для тренировок и любительских матчей." },
            new ProductModel { Id = 17, Name = "Кофеварка капельная", Price = 5990m, Category = CategoryEnum.HOME, ImageUrl = "https://picsum.photos/seed/p17/300/200", Description = "Готовит до 1.2 литра кофе, таймер отложенного старта." },
            new ProductModel { Id = 18, Name = "Робот-пылесос", Price = 19990m, Category = CategoryEnum.HOME, ImageUrl = "https://picsum.photos/seed/p18/300/200", Description = "Автоматическая уборка по расписанию, управление с телефона." },
            new ProductModel { Id = 19, Name = "Набор кастрюль (3 шт.)", Price = 7490m, Category = CategoryEnum.HOME, ImageUrl = "https://picsum.photos/seed/p19/300/200", Description = "Кастрюли с антипригарным покрытием, подходят для всех типов плит." },
            new ProductModel { Id = 20, Name = "Конструктор LEGO City", Price = 4490m, Category = CategoryEnum.TOYS, ImageUrl = "https://picsum.photos/seed/p20/300/200", Description = "Набор для сборки городской сцены, 350+ деталей." },
            new ProductModel { Id = 21, Name = "Кукла \"Алиса\"", Price = 1290m, Category = CategoryEnum.TOYS, ImageUrl = "https://picsum.photos/seed/p21/300/200", Description = "Кукла с подвижными суставами и набором аксессуаров." },
            new ProductModel { Id = 22, Name = "Радиоуправляемая машинка", Price = 3290m, Category = CategoryEnum.TOYS, ImageUrl = "https://picsum.photos/seed/p22/300/200", Description = "Внедорожник на пульте управления, разгон до 20 км/ч." },
        };

        public List<FilterCategory> categories = new List<FilterCategory>
        {
            new FilterCategory { Value = CategoryEnum.HOME, DisplayName = "Дом и сад" },
            new FilterCategory { Value = CategoryEnum.ELECTRONICS, DisplayName = "Электроника" },
            new FilterCategory { Value = CategoryEnum.CLOTHES, DisplayName = "Одежда" },
            new FilterCategory { Value = CategoryEnum.SPORT, DisplayName = "Спорт" },
            new FilterCategory { Value = CategoryEnum.BOOKS, DisplayName = "Книги" },
            new FilterCategory { Value = CategoryEnum.TOYS, DisplayName = "Игрушки" }
        };
    }
}
