using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCore.Data.EF.Configuration
{
    public class CategoryConfig
    {
        public CategoryConfig(EntityTypeBuilder<Category> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.ToTable("Categories");
            entityBuilder.Property(x => x.Name).IsRequired();
        }
    }
}
