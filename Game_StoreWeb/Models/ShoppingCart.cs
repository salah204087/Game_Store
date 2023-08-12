using Game_StoreAPI.Data;
using Game_StoreAPI.Models;
using Game_StoreWeb.Models.DTO;
using System;
using System.Data.Entity;

namespace Game_StoreWeb.Models
{
    public class ShoppingCart
    {
            public ApplicationDbContext _context { get; set; }
            public string ShoppingCartId { get; set; }
            public List<ShoppingCartItem> ShoppingCartItems { get; set; }
            public ShoppingCart(ApplicationDbContext context)
            {
                _context = context;
            }
            public static ShoppingCart GetShoppingCart(IServiceProvider service)
            {
                ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
                var context = service.GetService<ApplicationDbContext>();
                string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
                session.SetString("CartId", cartId);
                return new ShoppingCart(context) { ShoppingCartId = cartId };
            }
            public void AddItemToCart(Game game)
            {
                var ShoppingCartItem = _context.ShoppingCartItems.FirstOrDefault(n => n.Game.Id == game.Id && n.ShoppingCartId == ShoppingCartId);
                if (ShoppingCartItem == null)
                {
                    ShoppingCartItem = new ShoppingCartItem()
                    {
                        ShoppingCartId = ShoppingCartId,
                        Game = _context.Games.FirstOrDefault(n=>n.Id==game.Id),
                        Amount = 1
                    };
                    _context.ShoppingCartItems.Add(ShoppingCartItem);
                }
                else
                    ShoppingCartItem.Amount++;
                _context.SaveChanges();
            }
            public void RemoveItemFromCart(Game game)
            {
                var ShoppingCartItem = _context.ShoppingCartItems.FirstOrDefault(n => n.Game.Id == game.Id && n.ShoppingCartId == ShoppingCartId);
                if (ShoppingCartItem != null)
                {
                    if (ShoppingCartItem.Amount > 1)
                    {
                        ShoppingCartItem.Amount--;
                    }
                    else
                    {
                        _context.ShoppingCartItems.Remove(ShoppingCartItem);
                    }

                }
                _context.SaveChanges();
            }
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            var items = _context.ShoppingCartItems
                .Where(n => n.ShoppingCartId == ShoppingCartId)
                .ToList();

            foreach (var item in items)
            {
                _context.Entry(item).Reference(i => i.Game).Load();
            }

            return ShoppingCartItems ?? (ShoppingCartItems = items);
        }
        public double GetShoppingCartTotal()
            {
                var total = _context.ShoppingCartItems.Where(n => n.ShoppingCartId == ShoppingCartId).Select(n => n.Game.Price * n.Amount).Sum();
                return total;
            }
            public void ClearShoppingCart()
            {
                var items = _context.ShoppingCartItems.Where(n => n.ShoppingCartId == ShoppingCartId).ToList();
                _context.ShoppingCartItems.RemoveRange(items);
                _context.SaveChanges();
            }
        }
}
