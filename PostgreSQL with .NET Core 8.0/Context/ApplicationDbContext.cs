using Microsoft.EntityFrameworkCore;
using PostgreSQL_with_.NET_Core_8._0.Models;
using System;

namespace PostgreSQL_with_.NET_Core_8._0.Contexto
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<estudante>Estudantes{ get; set; }
    }
}
