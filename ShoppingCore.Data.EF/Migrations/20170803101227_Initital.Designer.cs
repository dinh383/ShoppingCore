using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ShoppingCore.Data.EF;
using ShoppingCore.Infrastructure.Enums;
using ShoppingCore.Data.Enums;

namespace ShoppingCore.Data.EF.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20170803101227_Initital")]
    partial class Initital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedName");

                    b.HasKey("Id");

                    b.ToTable("AppRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("IdentityRoleId");

                    b.Property<string>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("IdentityRoleId");

                    b.ToTable("AppRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppUserId");

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("AppUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppUserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("ProviderKey");

                    b.HasKey("UserId");

                    b.HasIndex("AppUserId");

                    b.ToTable("AppUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("RoleId");

                    b.Property<string>("UserId");

                    b.Property<string>("AppUserId");

                    b.Property<string>("IdentityRoleId");

                    b.HasKey("RoleId", "UserId");

                    b.HasIndex("AppUserId");

                    b.HasIndex("IdentityRoleId");

                    b.ToTable("AppUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens");
                });

            modelBuilder.Entity("ShoppingCore.Data.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Avatar");

                    b.Property<decimal>("Balance");

                    b.Property<DateTime?>("BirthDay");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<int>("Status");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("ShoppingCore.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Description");

                    b.Property<int>("DisplayLayout");

                    b.Property<string>("LanguageId");

                    b.Property<string>("Name");

                    b.Property<string>("OwnerId");

                    b.Property<string>("SeoAlias");

                    b.Property<string>("SeoDescription");

                    b.Property<string>("SeoKeywords");

                    b.Property<string>("SeoPageTitle");

                    b.Property<bool>("ShowHome");

                    b.Property<int>("SortOrder");

                    b.Property<string>("Thumbnail");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ShoppingCore.Data.Entities.ConfigParam", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Value1");

                    b.Property<int>("Value2");

                    b.Property<DateTime>("Value3");

                    b.Property<decimal>("Value4");

                    b.Property<bool>("Value5");

                    b.HasKey("Id");

                    b.ToTable("ConfigParams");
                });

            modelBuilder.Entity("ShoppingCore.Data.Entities.Language", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsDefault");

                    b.Property<string>("Name");

                    b.Property<string>("Resources");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("ShoppingCore.Data.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("OwnerId");

                    b.Property<int>("PaymentMethod");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ShoppingCore.Data.Entities.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OrderId");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("ShoppingCore.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Description");

                    b.Property<string>("LanguageId");

                    b.Property<string>("MoreImages");

                    b.Property<string>("Name");

                    b.Property<string>("OwnerId");

                    b.Property<decimal>("Price");

                    b.Property<string>("SeoAlias");

                    b.Property<string>("SeoDescription");

                    b.Property<string>("SeoKeywords");

                    b.Property<string>("SeoPageTitle");

                    b.Property<int>("SortOrder");

                    b.Property<string>("Thumbnails");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("IdentityRoleId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ShoppingCore.Data.Entities.AppUser")
                        .WithMany("Claims")
                        .HasForeignKey("AppUserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ShoppingCore.Data.Entities.AppUser")
                        .WithMany("Logins")
                        .HasForeignKey("AppUserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("ShoppingCore.Data.Entities.AppUser")
                        .WithMany("Roles")
                        .HasForeignKey("AppUserId");

                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("IdentityRoleId");
                });

            modelBuilder.Entity("ShoppingCore.Data.Entities.Category", b =>
                {
                    b.HasOne("ShoppingCore.Data.Entities.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");

                    b.HasOne("ShoppingCore.Data.Entities.AppUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("ShoppingCore.Data.Entities.Order", b =>
                {
                    b.HasOne("ShoppingCore.Data.Entities.AppUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("ShoppingCore.Data.Entities.OrderDetail", b =>
                {
                    b.HasOne("ShoppingCore.Data.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ShoppingCore.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ShoppingCore.Data.Entities.Product", b =>
                {
                    b.HasOne("ShoppingCore.Data.Entities.Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.HasOne("ShoppingCore.Data.Entities.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");

                    b.HasOne("ShoppingCore.Data.Entities.AppUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");
                });
        }
    }
}
