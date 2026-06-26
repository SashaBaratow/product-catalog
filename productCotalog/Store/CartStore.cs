using productCotalog.Models;

namespace productCotalog.Store
{
    public class CartStore
    {
        public List<CartModel> Items { get; set; } = new List<CartModel>();
        public int TotalItems;
    }
}
