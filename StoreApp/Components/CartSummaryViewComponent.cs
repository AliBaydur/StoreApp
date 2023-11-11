using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace StoreApp.Components
{
    public class CartSummeryViewComponent : ViewComponent
    {
        private readonly Cart _cart;
        public CartSummeryViewComponent(Cart cartService)
        {
            _cart = cartService;
        }

        public string Invoke()
        {
            return _cart.Lines.Count().ToString();
        }
    }
}