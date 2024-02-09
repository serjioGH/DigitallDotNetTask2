﻿namespace Cloth.Persistence.Ef.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cloth.Domain.Entities;
public class OrderLinesTypeConfiguration : IEntityTypeConfiguration<OrderLines>
{
    public void Configure(EntityTypeBuilder<OrderLines> builder)
    {
        builder.HasKey(p => new { p.OrderId, p.ClothId });
        builder.HasOne(p => p.Order)
            .WithMany(p => p.OrderLines)
            .HasForeignKey(p => p.OrderId);
        builder.HasOne(p => p.Size)
            .WithMany(s => s.OrderLines)
            .HasForeignKey(p => p.SizeId);
        builder.HasOne(p => p.Cloth)
            .WithMany(p => p.OrderDetails)
            .HasForeignKey(p => p.ClothId);
        builder.Property(p => p.Price)
            .HasColumnType("decimal(18, 2)");
    }
}
