﻿using Quiron.LojaVirtual.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class EfDbContext : DbContext
    {
        public DbSet<Produto> Produtos {get; set;}


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);// Comentada

          
            // A linha abaixo remove a pluralização 
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
            // A linha abaixo insere a Pluralização na tabela desejada
            modelBuilder.Entity<Produto>().ToTable("Produtos");

        }
    }
}