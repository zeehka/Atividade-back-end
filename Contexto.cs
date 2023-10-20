using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LHpet.Models
{
    public class Contexto: DbContext
    {
            public Contexto(DbContextOptions<Contexto> options) : base(options)
            {
            }
            public DbSet<Cliente> Cliente { get; set; }

        
    }
}

