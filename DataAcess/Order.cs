using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp.DataAcess
{
    public class Order
    {
        public int Id { get; set; }

        public User Courier { get; set; }

        public User Manager { get; set; }

        public Coupon Coupons { get; set; }

        public Transaction Payment { get; set; }

        public DateTime OrderedAt { get; set; }

        public DateTime DeliveredAt { get; set; }

        public Status State { get; set; }

        public string Comments { get; set; }

        public string Phone { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public User Cook { get; set; }


    }
}
