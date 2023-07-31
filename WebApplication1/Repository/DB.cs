using TesteAdmissao.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;


namespace TesteAdmissao.Repository
{
    public class DB : DbContext
    {
        public DB() : base("name=BancoContexto")
        {
            Database.SetInitializer<DB>(null);

        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Cargo_Vencimentos> Cargo_Vencimentos { get; set; }
        public DbSet<Pessoa_Salario> Pessoa_Salarios { get; set; }
        public DbSet<Vencimentos> Vencimentos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

    }

    public class Repositorio
    {
        public static DB banco = null;

        static Repositorio()
        {
            if (banco == null)
                banco = new DB();
        }

    }


}