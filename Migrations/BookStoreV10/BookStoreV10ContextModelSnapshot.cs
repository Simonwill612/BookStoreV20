﻿// <auto-generated />
using System;
using BookStoreV10.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStoreV10.Migrations.BookStoreV10
{
    [DbContext(typeof(BookStoreV10Context))]
    partial class BookStoreV10ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookStoreV10.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("BookStoreV10.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("AuthorAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("BookStoreV10.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AuthorNameNavigationAuthorId")
                        .HasColumnType("int");

                    b.Property<byte[]>("CoverImageData")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Describe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PublisherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PublisherNameNavigationPublisherId")
                        .HasColumnType("int");

                    b.Property<int?>("StoreOwnerId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorNameNavigationAuthorId");

                    b.HasIndex("PublisherNameNavigationPublisherId");

                    b.HasIndex("StoreOwnerId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("BookStoreV10.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"));

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("CartId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("BookStoreV10.Models.CartItem", b =>
                {
                    b.Property<int>("CartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartItemId"));

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<int?>("CartId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartItemId");

                    b.HasIndex("BookId");

                    b.HasIndex("CartId");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("BookStoreV10.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BookStoreV10.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StoreOwnerId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("StoreOwnerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("BookStoreV10.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailId"));

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("BookStoreV10.Models.Publisher", b =>
                {
                    b.Property<int>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PublisherId"));

                    b.Property<string>("PublisherAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublisherLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublisherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PublisherId");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("BookStoreV10.Models.StoreOwner", b =>
                {
                    b.Property<int>("StoreOwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoreOwnerId"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserName")
                        .HasColumnType("int");

                    b.HasKey("StoreOwnerId");

                    b.ToTable("StoreOwner");
                });

            modelBuilder.Entity("BookStoreV10.Models.Book", b =>
                {
                    b.HasOne("BookStoreV10.Models.Author", "AuthorNameNavigation")
                        .WithMany("Books")
                        .HasForeignKey("AuthorNameNavigationAuthorId");

                    b.HasOne("BookStoreV10.Models.Publisher", "PublisherNameNavigation")
                        .WithMany("Books")
                        .HasForeignKey("PublisherNameNavigationPublisherId");

                    b.HasOne("BookStoreV10.Models.StoreOwner", "StoreOwner")
                        .WithMany("Books")
                        .HasForeignKey("StoreOwnerId");

                    b.Navigation("AuthorNameNavigation");

                    b.Navigation("PublisherNameNavigation");

                    b.Navigation("StoreOwner");
                });

            modelBuilder.Entity("BookStoreV10.Models.Cart", b =>
                {
                    b.HasOne("BookStoreV10.Models.Customer", "Customer")
                        .WithMany("Carts")
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BookStoreV10.Models.CartItem", b =>
                {
                    b.HasOne("BookStoreV10.Models.Book", "Book")
                        .WithMany("CartItems")
                        .HasForeignKey("BookId");

                    b.HasOne("BookStoreV10.Models.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId");

                    b.Navigation("Book");

                    b.Navigation("Cart");
                });

            modelBuilder.Entity("BookStoreV10.Models.Order", b =>
                {
                    b.HasOne("BookStoreV10.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("BookStoreV10.Models.StoreOwner", "StoreOwner")
                        .WithMany("Orders")
                        .HasForeignKey("StoreOwnerId");

                    b.Navigation("Customer");

                    b.Navigation("StoreOwner");
                });

            modelBuilder.Entity("BookStoreV10.Models.OrderDetail", b =>
                {
                    b.HasOne("BookStoreV10.Models.Book", "Book")
                        .WithMany("OrderDetails")
                        .HasForeignKey("BookId");

                    b.HasOne("BookStoreV10.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId");

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BookStoreV10.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookStoreV10.Models.Book", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("BookStoreV10.Models.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("BookStoreV10.Models.Customer", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("BookStoreV10.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("BookStoreV10.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookStoreV10.Models.StoreOwner", b =>
                {
                    b.Navigation("Books");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
