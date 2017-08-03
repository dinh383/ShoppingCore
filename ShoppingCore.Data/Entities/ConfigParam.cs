using ShoppingCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCore.Data.Entities
{
    public class ConfigParam : DomainEntity<string>
    {
        public string Value1 { get; set; }
        public int Value2 { get; set; }
        public DateTime Value3 { get; set; }
        public decimal Value4 { get; set; }
        public bool Value5 { get; set; }
    }
}
