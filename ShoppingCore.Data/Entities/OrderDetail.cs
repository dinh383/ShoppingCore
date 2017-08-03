using ShoppingCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCore.Data.Entities
{

    public class OrderDetail : DomainEntity<int>
    {
        public int ProductId { get; set; }

        public int OrderId { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public virtual Product Product { get; set; }

        public virtual Order Order { get; set; }

    }
}
