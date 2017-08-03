using ShoppingCore.Data.Interfaces;
using ShoppingCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCore.Infrastructure.Enums;

namespace ShoppingCore.Data.Entities
{
    public class Language : DomainEntity<string>, ISwitchable
    {
        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public string Resources { get; set; }

        public Status Status { get; set; }
    }
}
