
using Microsoft.EntityFrameworkCore;
using Semana4.Models;
using System;
using System.Collections.Generic;

namespace Semana4.Data;
public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Modelo> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Modelo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MOVIES__3214EC072A30C1A8");

            entity.ToTable("MODELO");

            entity.Property(e => e.Precio).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.FechaRealizacion).HasColumnType("date");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}