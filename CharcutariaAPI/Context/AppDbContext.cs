﻿using CharcutariaAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CharcutariaAPI.Context
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base( options)
        {

        }

        public DbSet<Filial>? Filiais { get; set; }
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; }

    }
}
