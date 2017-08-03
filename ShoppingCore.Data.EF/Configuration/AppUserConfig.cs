using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCore.Data.EF.Configuration
{
    public class AppUserConfig
    {
        public AppUserConfig(EntityTypeBuilder<AppUser> entityBuilder)
        {
            entityBuilder.ToTable("AppUsers");
            entityBuilder.Property(x => x.FullName).IsRequired().HasMaxLength(128);

        }
    }
}
