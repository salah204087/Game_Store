using Game_StoreAPI.Data;
using Game_StoreAPI.Repository.IRepository;
using Game_StoreWeb.Models;
using Game_StoreWeb.Models.VM;
using Game_StoreWeb.Services.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Game_StoreAPI.Models;
using Game_StoreAPI.Services.IServices;
using Microsoft.AspNetCore.Authorization;

namespace Game_StoreWeb.Controllers
{
    public class OrderController : Controller
    {
        private readonly IGameRepository _gameRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly IOrderService _ordersService;
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public OrderController(IGameRepository gameRepository, ShoppingCart shoppingCart, IOrderService ordersService, ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _gameRepository = gameRepository;
            _shoppingCart = shoppingCart;
            _ordersService = ordersService;
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }
        [Authorize]
        public IActionResult Index()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userRole = User.FindFirstValue(ClaimTypes.Role);
            var orders = _ordersService.GetOrdersByUserIdAndRole(userId, userRole);
            return View(orders);
        }
        [Authorize]
        public IActionResult ShoppingCart()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            var response = new ShoppingCartVM()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
                
            };

            return View(response);
        }
        public IActionResult AddItemToShoppingCart(int id)
        {
            var item =_context.Games.FirstOrDefault(n=>n.Id==id);
            if (item != null)
            {
                _shoppingCart.AddItemToCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }
        public IActionResult RemoveItemFromShoppingCart(int id)
        {
            var item = _context.Games.FirstOrDefault(n => n.Id == id);
            if (item != null)
            {
                _shoppingCart.RemoveItemFromCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }
        public IActionResult CompleteOrder()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userEmailAddress = User.FindFirstValue(ClaimTypes.Email);
            _ordersService.StoreOrder(items, userId, userEmailAddress);
            _shoppingCart.ClearShoppingCart();
            return View("OrderCompleted");
        }
    }
}
