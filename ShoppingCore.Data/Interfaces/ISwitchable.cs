using ShoppingCore.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCore.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
