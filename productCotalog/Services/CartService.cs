using productCotalog.Models;
using productCotalog.Store;

namespace productCotalog.Services
{
    public class CartService
    {
        public List<CartModel> cartItems { get; set; }
        public int TotalItems;
        public decimal TotalPrice;


        public void UpdateTotalItems()
        {
            TotalItems = cartItems.Sum(item => item.count);
        }
        public void CalculateTotalPrice()
        {
            TotalPrice = cartItems.Sum(item => item.product.Price * item.count);
        }
        public CartService(CartStore store)
        {
            cartItems = store.Items;
        }

        public List<CartModel> GetCartItems()
        {
            return cartItems;
        }

        public decimal GetTotalPrice()
        {
            return TotalPrice;
        }

        public int GetTotalItemsCount()
        {
            return TotalItems;  
        }

        public void DeleteCart(ProductModel product)
        {
            var existing = cartItems.FirstOrDefault(item => item.product.Id == product.Id);
            if (existing is not null)
            {
                existing.count--;
                if (existing.count <= 0)
                {
                    cartItems.Remove(existing);
                }
            }
            CalculateTotalPrice();
            UpdateTotalItems();
        }
        public void AddCart(ProductModel product)
        {
            var existing = cartItems.FirstOrDefault(item => item.product.Id == product.Id);

            if (existing is not null)
            {
                existing.count++; 
            }
            else
            {
                cartItems.Add(new CartModel 
                {
                    product = product,
                    count = 1
                });
            }
            CalculateTotalPrice();
            UpdateTotalItems();
        }
    }
}
