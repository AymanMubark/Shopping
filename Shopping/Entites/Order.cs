using System;
using System.ComponentModel.DataAnnotations;
using Shopping.Entites.Enums;

namespace Shopping.Entites
{
    public class Order : Base
    {
        public string OrderId { get; set; } = "";
        public  OrderStatus Status { get; set; } = OrderStatus.New;
        public Guid? AppUserId { get; set; }
        public virtual AppUser? AppUser { get; set; }
        public string Phone { get; set; } = "";
        public string Email { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public double Total { get; set; } = 0;
        public double Tax { get; set; } = 0;
        public string Region { get; set; } = "";
        public string City { get; set; } = "";
        public string Details { get; set; } = "";
        public string ZipCode { get; set; } = "";
        public string Note { get; set; } = "";
        public ICollection<OrderDetail> OrderDetails { get; set; } = null!;
    }
}

