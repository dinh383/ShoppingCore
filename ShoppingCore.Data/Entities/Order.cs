using ShoppingCore.Data.Enums;
using ShoppingCore.Data.Interfaces;
using ShoppingCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCore.Data.Entities
{
    public class Order : DomainEntity<int>, IDateTracking, IHasOwner<string>
    {

        public string OwnerId { set; get; }
        public virtual AppUser Owner { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }

        public PaymentMethod PaymentMethod { get; set; }
    }
}
