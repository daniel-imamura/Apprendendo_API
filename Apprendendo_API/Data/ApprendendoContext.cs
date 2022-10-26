using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Apprendendo_API.Models;

namespace Apprendendo_API.Data
{
    public class ApprendendoContext : DbContext
    {
        public ApprendendoContext(DbContextOptions<ApprendendoContext> options) : base (options) 
        {

        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Guia> Guia { get; set; }
    }
}