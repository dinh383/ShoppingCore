using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ShoppingCore.Data.Interfaces;
using ShoppingCore.Infrastructure.Enums;
using System;

namespace ShoppingCore.Data.Entities
{
    public class AppUser : IdentityUser, IDateTracking, ISwitchable
    {
        public string FullName { get; set; }

        public DateTime? BirthDay { set; get; }

        public decimal Balance { get; set; }

        public string Avatar { get; set; }

        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public Status Status { set; get; }
    }
}