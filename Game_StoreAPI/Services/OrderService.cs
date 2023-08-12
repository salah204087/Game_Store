using Game_StoreAPI.Services.IServices;
using Game_StoreAPI.Models;
using System;
using Game_StoreAPI.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using System.Linq;
using Game_StoreAPI.Repository.IRepository;
using Game_StoreAPI.Models.DTO;
using Microsoft.AspNetCore.Authorization;

namespace Game_StoreAPI.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _ordersRepository;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;
        public OrderService(IOrderRepository ordersRepository, IMapper mapper, ApplicationDbContext context)
        {
            _ordersRepository = ordersRepository;
            _mapper = mapper;
            _context = context;
        }
        [Authorize]
        public List<Order> GetOrdersByUserIdAndRole(string userId, string userRole)
        {
            var orders = _context.Orders
                 .Include(n => n.OrderItems)
                 .ThenInclude(n => n.Game)
                 .Include(n => n.User)
                 .ToList();
            if (userRole != "admin")
            {
                orders = orders.Where(n => n.UserId == userId).ToList();
            }
            return orders;
        }
        [Authorize]
        public void StoreOrder(List<ShoppingCartItem> items, string userId, string userEmailAddress)
        {
            var order = new Order()
            {
                UserId = userId,
                UserName = userEmailAddress
            };
            _ordersRepository.Create(order);

            foreach (var item in items)
            {
                var orderItem = new OrderItem()
                {
                    Amount = item.Amount,
                    GameId = item.Game.Id,
                    OrderId = order.Id,
                    Price = item.Game.Price 
                };
                _context.OrderItems.Add(orderItem);
            }
            _context.SaveChanges();

        }
    }
}
