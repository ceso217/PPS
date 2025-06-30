using GestionDeStock.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.DBContext
{
    public class StockBDContext : DbContext
    {
        public StockBDContext() {}

        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Deposito> Depositos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }
        public DbSet<Subcategoria> Subcategorias { get; set; }
        public DbSet<Transportista> Transportistas { get; set; }
        public DbSet<UnidadMedida> UnidadesDeMedida { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // define the foreign key and the one-to-many relationship
            modelBuilder.Entity<Subcategoria>()
                .HasOne(s => s.Categoria)
                .WithMany(c => c.Subcategorias)
                .HasForeignKey(s => s.CategoriaId);

            modelBuilder.Entity<Articulo>()
                .HasIndex(a => new { a.CategoriaId, a.CodigoSubcategoria, a.CodigoArticulo });

            modelBuilder.Entity<Articulo>()
                .HasOne(a => a.Marca)
                .WithMany(m => m.Articulos)
                .HasForeignKey(a => a.MarcaId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Articulo>()
                .HasOne(a => a.UnidadMedida)
                .WithMany(u => u.Articulos)
                .HasForeignKey(a => a.UnidadMedidaId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Movimiento>()
                .HasOne(i => i.Proveedor)
                .WithMany(p => p.Movimientos)
                .HasForeignKey(i => i.ProveedorId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Movimiento>()
                .HasOne(m => m.Deposito)
                .WithMany(d => d.Movimientos)
                .HasForeignKey(m => m.DepositoId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Movimiento>()
                .HasOne(i => i.Transportista)
                .WithMany(t => t.Movimientos)
                .HasForeignKey(i => i.TransportistaId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Movimiento>()
                .HasOne(i => i.Articulo)
                .WithMany(a => a.Movimientos)
                .HasForeignKey(i => i.ArticuloId);
        }

        // database connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["StockBD"].ConnectionString;
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        /*
         Para hacer las migraciones:
        Add-Migration NombreMigración
        Update-Database
         */
    }
}
