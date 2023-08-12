﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Game_StoreAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser? User { get; set; }
        public List<OrderItem>? OrderItems { get; set; }
    }
}
