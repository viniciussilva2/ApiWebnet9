﻿using ApiWEBNET9.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiWEBNET9.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ProdutoModel> Produtos { get; set; }


    }
}
