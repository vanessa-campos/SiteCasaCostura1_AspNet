using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PIE5_VanessaCampos.Models
{
    public partial class CasaCosturaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseMySql("Server=MYSQL5040.site4now.net;Database=db_a837b7_casacos;Uid=a837b7_casacos;Pwd=casacos21");
        }

        public virtual DbSet<Atendimento> Atendimento { get; set; }
        public virtual DbSet<Carrinho> Carrinho { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}